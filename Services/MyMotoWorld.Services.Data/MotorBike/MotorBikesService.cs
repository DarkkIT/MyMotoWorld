namespace MyMotoWorld.Services.Data
{
    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Models;
    using MyMotoWorld.Data.Common.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MyMotoWorld.Services.Mapping;
    using System.Linq;

    public class MotorBikesService : IMotorBikesService
    {
        private readonly IDeletableEntityRepository<MotorBike> motorBikeRepository;

        public MotorBikesService(IDeletableEntityRepository<MotorBike> motorBikeRepository)
        {
            this.motorBikeRepository = motorBikeRepository;
        }

        public IEnumerable<MotorBike> GetAll<MotorBike>()
        {
            return this.motorBikeRepository.All().To<MotorBike>().ToList();
        }

        public int GetCount()
        {
            return this.motorBikeRepository.AllAsNoTracking().Count();
        }

    }
}
