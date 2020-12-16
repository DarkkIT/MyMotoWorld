// ReSharper disable VirtualMemberCallInConstructor
namespace MyMotoWorld.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;
    using MyMotoWorld.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Sales = new HashSet<Sale>();
            this.NewsList = new HashSet<News>();
            this.Votes = new HashSet<Vote>();
            this.FavoriteBikes = new HashSet<FavoriteBikes>();
            this.FavoriteNews = new HashSet<FavoriteNews>();
            this.UserMassages = new HashSet<UserMessage>();
            this.Carts = new HashSet<Cart>();
        }

        public decimal TotalSpent { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        public virtual ICollection<News> NewsList { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }

        public virtual ICollection<FavoriteBikes> FavoriteBikes { get; set; }

        public virtual ICollection<FavoriteNews> FavoriteNews { get; set; }

        public virtual ICollection<UserMessage> UserMassages { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
