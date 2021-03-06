﻿namespace MyMotoWorld.Data
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using MyMotoWorld.Data.Common.Models;
    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Models;
    using MyMotoWorld.Models.Parts;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
            typeof(ApplicationDbContext).GetMethod(
                nameof(SetIsDeletedQueryFilter),
                BindingFlags.NonPublic | BindingFlags.Static);

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactMessage> ContactMessages { get; set; }

        public virtual DbSet<UserMessage> UserMessages { get; set; }

        public virtual DbSet<Message> Messages { get; set; }

        public virtual DbSet<Cart> Carts { get; set; }

        public virtual DbSet<FavoriteBikes> FavoriteBikes { get; set; }

        public virtual DbSet<FavoriteNews> FavoriteNews { get; set; }

        public virtual DbSet<Vote> Votes { get; set; }

        public virtual DbSet<News> News { get; set; }

        public virtual DbSet<RearSuspension> RearSuspensions { get; set; }

        public virtual DbSet<RearBrake> RearBrakes { get; set; }

        public virtual DbSet<FrontSuspension> FrontSuspensions { get; set; }

        public virtual DbSet<FrontBrake> FrontBrakes { get; set; }

        public virtual DbSet<Engine> Engines { get; set; }

        public virtual DbSet<Image> Images { get; set; }

        public virtual DbSet<BikeType> BikeTypes { get; set; }

        public virtual DbSet<CoolingSystem> CoolingSystems { get; set; }

        public virtual DbSet<Extra> Extras { get; set; }

        public virtual DbSet<MotorBike> MotorBikes { get; set; }

        public virtual DbSet<Transmission> Transmissions { get; set; }

        public virtual DbSet<Sale> Sales { get; set; }

        public virtual DbSet<MotorBikeExtra> MotorBikeExtras { get; set; }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            this.ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        // Applies configurations
        private void ConfigureUserIdentityRelations(ModelBuilder builder)
             => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
