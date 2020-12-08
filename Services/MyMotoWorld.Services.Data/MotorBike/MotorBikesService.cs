namespace MyMotoWorld.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
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

        public MotorBikesService(
            IDeletableEntityRepository<MotorBike> motorBikeRepository,
            IDeletableEntityRepository<BikeType> bikeTypeRepository,
            IDeletableEntityRepository<Transmission> transmissionRepozitory,
            IDeletableEntityRepository<FrontSuspension> frontSuspensionRepository,
            IDeletableEntityRepository<RearSuspension> rearSuspensionRepository,
            IDeletableEntityRepository<FrontBrake> frontBreakRepository,
            IDeletableEntityRepository<RearBrake> rearBreakRepository,
            IDeletableEntityRepository<Engine> engineRepositiry,
            IDeletableEntityRepository<CoolingSystem> coolingSystemRepository)
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

            if (!this.coolingSystemRepository.All().Any(x => x.Name == input.EngineCoolingSystemName))
            {
                await this.coolingSystemRepository.AddAsync(new CoolingSystem { Name = input.EngineCoolingSystemName });
            }

            if (this.engineRepositiry.All().Any(x => x.Name == input.EngineName))
            {
                motorBike.Engine = this.engineRepositiry.All().Where(x => x.Name == input.EngineName).First();
            }
            else
            {
                motorBike.Engine = new Engine { Name = input.EngineName, EngineCapacity = input.EngineCapacity, EnginePower = input.EnginePower, CoolingSystem = this.coolingSystemRepository.All().Where(x => x.Name == input.EngineCoolingSystemName).First() };
            }

            await this.motorBikeRepository.AddAsync(motorBike);
            await this.motorBikeRepository.SaveChangesAsync();
        }

        public IEnumerable<MotorBikeViewModel> GetAllBikes<T>(int page, int itemsPerPage)
        {
            var model = this.motorBikeRepository.All().OrderByDescending(x => x.Id).Skip((page - 1) * itemsPerPage).Take(itemsPerPage).To<MotorBikeViewModel>().ToList();

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
    }
}
