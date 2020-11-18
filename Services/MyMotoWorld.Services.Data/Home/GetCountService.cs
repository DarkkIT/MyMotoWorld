namespace MyMotoWorld.Services.Data.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Models;
    using MyMotoWorld.Models.Parts;
    using MyMotoWorld.Web.ViewModels.Home;

    public class GetCountService : IGetCountService
    {
        private readonly IDeletableEntityRepository<MotorBike> motorBikeRepository;
        private readonly IDeletableEntityRepository<Engine> engineRepository;
        private readonly IDeletableEntityRepository<BikeType> bikeTypeRepository;
        private readonly IDeletableEntityRepository<Extra> extraRepository;

        public GetCountService(
            IDeletableEntityRepository<MotorBike> motorBikeRepository,
            IDeletableEntityRepository<BikeType> bikeTypeRepository,
            IDeletableEntityRepository<Engine> engineRepository,
            IDeletableEntityRepository<Extra> extraRepository)
        {
            this.motorBikeRepository = motorBikeRepository;
            this.engineRepository = engineRepository;
            this.bikeTypeRepository = bikeTypeRepository;
            this.extraRepository = extraRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                BikeTypeCount = this.bikeTypeRepository.All().Count(),
                EngineCount = this.engineRepository.All().Count(),
                ExtrasCount = this.extraRepository.All().Count(),
                MotorBikeCount = this.motorBikeRepository.All().Count(),
                MostLikedBike = this.motorBikeRepository.All().OrderByDescending(x => x.Liked).FirstOrDefault().Model,
                MostLikedType = this.bikeTypeRepository.All().OrderByDescending(x => x.Liked).FirstOrDefault().Name,
            };

            return data;
        }
    }
}
