namespace MyMotoWorld.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Models;
    using MyMotoWorld.Models.Parts;
    using MyMotoWorld.Services.Mapping;
    using MyMotoWorld.Web.ViewModels.Admins;
    using MyMotoWorld.Web.ViewModels.MotorBike;

    public class MotorBikesService : IMotorBikesService
    {
        private readonly IDeletableEntityRepository<MotorBike> motorBikeRepository;
        private readonly IDeletableEntityRepository<BikeType> bikeTypeRepository;
        private readonly IDeletableEntityRepository<Transmission> transmissionRepozitory;
        private readonly IDeletableEntityRepository<FrontSuspension> frontSuspensionRepository;
        private readonly IDeletableEntityRepository<RearSuspension> rearSuspensionRepository;
        private readonly IDeletableEntityRepository<FrontBrake> frontBreakRepository;
        private readonly IDeletableEntityRepository<RearBrake> rearBreakRepository;
        private readonly IDeletableEntityRepository<Engine> engineRepositiry;
        private readonly IDeletableEntityRepository<CoolingSystem> coolingSystemRepository;
        private readonly IRepository<FavoriteBikes> favoriteBikesRepository;
        private readonly IDeletableEntityRepository<Cart> cardRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;

        public MotorBikesService(
            IDeletableEntityRepository<MotorBike> motorBikeRepository,
            IDeletableEntityRepository<BikeType> bikeTypeRepository,
            IDeletableEntityRepository<Transmission> transmissionRepozitory,
            IDeletableEntityRepository<FrontSuspension> frontSuspensionRepository,
            IDeletableEntityRepository<RearSuspension> rearSuspensionRepository,
            IDeletableEntityRepository<FrontBrake> frontBreakRepository,
            IDeletableEntityRepository<RearBrake> rearBreakRepository,
            IDeletableEntityRepository<Engine> engineRepositiry,
            IDeletableEntityRepository<CoolingSystem> coolingSystemRepository,
            IRepository<FavoriteBikes> favoriteBikesRepository,
            IDeletableEntityRepository<Cart> cardRepository,
            IDeletableEntityRepository<ApplicationUser> userRepository)
        {
            this.motorBikeRepository = motorBikeRepository;
            this.bikeTypeRepository = bikeTypeRepository;
            this.transmissionRepozitory = transmissionRepozitory;
            this.frontSuspensionRepository = frontSuspensionRepository;
            this.rearSuspensionRepository = rearSuspensionRepository;
            this.frontBreakRepository = frontBreakRepository;
            this.rearBreakRepository = rearBreakRepository;
            this.engineRepositiry = engineRepositiry;
            this.coolingSystemRepository = coolingSystemRepository;
            this.favoriteBikesRepository = favoriteBikesRepository;
            this.cardRepository = cardRepository;
            this.userRepository = userRepository;
        }

        public async Task AddBikeAsync(AddMotorBikeInputModel input)
        {
            var motorBike = new MotorBike
            {
                Name = input.Name,
                Model = input.Model,
                Price = input.Price,
                Weight = input.Weight,
                Length = input.Length,
                Height = input.Height,
                SeatHeight = input.SeatHeight,
                Descrition = input.Descrition,
            };

            if (this.bikeTypeRepository.All().Any(x => x.Name == input.BikeType))
            {
                motorBike.BikeType = this.bikeTypeRepository.All().Where(x => x.Name == input.BikeType).First();
            }
            else
            {
                motorBike.BikeType = new BikeType { Name = input.BikeType, Descrition = input.BikeTypeDesctiption };
            }

            if (this.transmissionRepozitory.All().Any(x => x.Name == input.Transmission))
            {
                motorBike.Transmission = this.transmissionRepozitory.All().Where(x => x.Name == input.Transmission).First();
            }
            else
            {
                motorBike.Transmission = new Transmission { Name = input.Transmission };
            }

            if (this.frontSuspensionRepository.All().Any(x => x.Name == input.FrontSuspension))
            {
                motorBike.FrontSuspension = this.frontSuspensionRepository.All().Where(x => x.Name == input.FrontSuspension).First();
            }
            else
            {
                motorBike.FrontSuspension = new FrontSuspension { Name = input.FrontSuspension };
            }

            if (this.rearSuspensionRepository.All().Any(x => x.Name == input.RearSuspension))
            {
                motorBike.RearSuspension = this.rearSuspensionRepository.All().Where(x => x.Name == input.RearSuspension).First();
            }
            else
            {
                motorBike.RearSuspension = new RearSuspension { Name = input.RearSuspension };
            }

            if (this.frontBreakRepository.All().Any(x => x.Name == input.FrontBrakes))
            {
                motorBike.FrontBrakes = this.frontBreakRepository.All().Where(x => x.Name == input.FrontBrakes).First();
            }
            else
            {
                motorBike.FrontBrakes = new FrontBrake { Name = input.FrontBrakes };
            }

            if (this.rearBreakRepository.All().Any(x => x.Name == input.RearBrakes))
            {
                motorBike.RearBrakes = this.rearBreakRepository.All().Where(x => x.Name == input.RearBrakes).First();
            }
            else
            {
                motorBike.RearBrakes = new RearBrake { Name = input.RearBrakes };
            }

            if (!this.coolingSystemRepository.All().Any(x => x.Name == input.CoolingSystem))
            {
                await this.coolingSystemRepository.AddAsync(new CoolingSystem { Name = input.CoolingSystem });
            }

            if (this.engineRepositiry.All().Any(x => x.Name == input.EngineName))
            {
                motorBike.Engine = this.engineRepositiry.All().Where(x => x.Name == input.EngineName).First();
            }
            else
            {
                motorBike.Engine = new Engine { Name = input.EngineName, EngineCapacity = input.EngineCapacity, EnginePower = input.EnginePower, CoolingSystem = this.coolingSystemRepository.All().Where(x => x.Name == input.CoolingSystem).First() };
            }

            await this.motorBikeRepository.AddAsync(motorBike);
            await this.motorBikeRepository.SaveChangesAsync();
        }

        public async Task DeleteBike(int id)
        {
            var bike = this.motorBikeRepository.AllAsNoTracking().FirstOrDefault(x => x.Id == id);

            this.motorBikeRepository.Delete(bike);
            await this.motorBikeRepository.SaveChangesAsync();
        }

        public async Task UnDeleteBike(int id)
        {
            var bike = this.motorBikeRepository.AllWithDeleted().FirstOrDefault(x => x.Id == id);

            bike.IsDeleted = false;
            bike.DeletedOn = null;
            await this.motorBikeRepository.SaveChangesAsync();
        }

        public async Task EditBikeAsync(EditBikeInputModel input, int id)
        {
            var bike = this.motorBikeRepository.All().FirstOrDefault(x => x.Id == id);

            bike.Name = input.Name;
            bike.Model = input.Model;
            bike.Price = input.Price;
            bike.Weight = input.Weight;
            bike.Length = input.Length;
            bike.Height = input.Height;
            bike.SeatHeight = input.SeatHeight;
            bike.BikeType = new BikeType { Name = input.BikeType };
            bike.BikeType.Descrition = input.BikeTypeDesctiption;
            bike.Engine = new Engine { Name = input.EngineName, EnginePower = input.EnginePower, EngineCapacity = input.EngineCapacity, CoolingSystem = new CoolingSystem { Name = input.CoolingSystem } };
            bike.Transmission = new Transmission { Name = input.Transmission };
            bike.FrontSuspension = new FrontSuspension { Name = input.FrontSuspension };
            bike.RearSuspension = new RearSuspension { Name = input.RearSuspension };
            bike.FrontBrakes = new FrontBrake { Name = input.FrontBrakes };
            bike.RearBrakes = new RearBrake { Name = input.RearBrakes };
            bike.Descrition = input.Descrition;
            bike.ModifiedOn = DateTime.UtcNow;

            await this.motorBikeRepository.SaveChangesAsync();
        }

        public IEnumerable<MotorBikeViewModel> GetAllBikes<T>(int page, int itemsPerPage)
        {
            var model = this.motorBikeRepository.All().OrderByDescending(x => x.Id).Skip((page - 1) * itemsPerPage).Take(itemsPerPage).To<MotorBikeViewModel>().ToList();

            return model;
        }

        public IEnumerable<MotorBikeViewModel> GetAllBikesWithDeleted<T>(int page, int itemsPerPage)
        {
            var model = this.motorBikeRepository.AllWithDeleted().OrderByDescending(x => x.Id).Skip((page - 1) * itemsPerPage).Take(itemsPerPage).To<MotorBikeViewModel>().ToList();

            return model;
        }

        public MotorBikeFullInfoViewModel GetById<T>(int id)
        {
            var model = this.motorBikeRepository.All().To<MotorBikeFullInfoViewModel>().FirstOrDefault(x => x.Id == id);

            return model;
        }

        public int GetCount()
        {
            return this.motorBikeRepository.All().Count();
        }

        public async Task AddBikeToFavorit(int id, string userId)
        {
            await this.favoriteBikesRepository.AddAsync(new FavoriteBikes { MotorBikeId = id, UserId = userId });

            await this.motorBikeRepository.SaveChangesAsync();
            await this.favoriteBikesRepository.SaveChangesAsync();
        }

        public async Task RemoveBikeFromFavorit(int id, string userId)
        {
            var favorite = this.favoriteBikesRepository.AllAsNoTracking().FirstOrDefault(x => x.MotorBikeId == id && x.UserId == userId);

            this.favoriteBikesRepository.Delete(favorite);

            var bike = this.motorBikeRepository.All().FirstOrDefault(x => x.Id == id);

            await this.favoriteBikesRepository.SaveChangesAsync();
        }

        public IEnumerable<MotorBikeViewModel> GetAllFavoriteBikes<T>(int page, int itemsPerPage, string userId)
        {
            var model = this.motorBikeRepository.All().Where(x => x.FavoriteBikes.Any(x => x.UserId == userId)).Skip((page - 1) * itemsPerPage).Take(itemsPerPage).To<MotorBikeViewModel>().ToList();

            return model;
        }

        public async Task AddBikeToCart(int id, string userId)
        {
            if (this.cardRepository.All().Any(x => x.UserId == userId && x.MotorBikeId == id && x.IsDeleted == false))
            {
                var motorBike = this.motorBikeRepository.All().FirstOrDefault(x => x.Id == id);

                motorBike.Quantity += 1;
            }
            else
            {
                await this.cardRepository.AddAsync(new Cart
                {
                    MotorBikeId = id,
                    UserId = userId,
                    Address = null,
                });

                var motorBike = this.motorBikeRepository.All().FirstOrDefault(x => x.Id == id);

                motorBike.Quantity += 1;
            }

            await this.motorBikeRepository.SaveChangesAsync();
            await this.cardRepository.SaveChangesAsync();
        }

        public async Task RemoveBikeFromCart(int id, string userId)
        {
            var cardItem = this.cardRepository.AllAsNoTracking().FirstOrDefault(x => x.MotorBikeId == id && x.UserId == userId && x.IsDeleted == false);

            if (this.motorBikeRepository.All().FirstOrDefault(x => x.Id == id).Quantity <= 1)
            {
                this.cardRepository.Delete(cardItem);
                this.motorBikeRepository.All().FirstOrDefault(x => x.Id == id).Quantity = 0;
            }
            else
            {
                this.motorBikeRepository.All().FirstOrDefault(x => x.Id == id).Quantity -= 1;
            }

            await this.motorBikeRepository.SaveChangesAsync();
            await this.cardRepository.SaveChangesAsync();
        }

        public IEnumerable<MotorBikeViewModel> GetAllCartBikes<T>(int page, int itemsPerPage, string userId)
        {
            var model = this.motorBikeRepository.All()
                .Where(x => x.Carts.Any(x => x.UserId == userId && x.IsDeleted == false))
                .To<MotorBikeViewModel>().ToList();

            return model;
        }
    }
}
