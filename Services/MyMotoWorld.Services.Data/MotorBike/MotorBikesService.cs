namespace MyMotoWorld.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Mapping;

    public class MotorBikesService : IMotorBikesService
    {
        private readonly IDeletableEntityRepository<MotorBike> motorBikeRepository;

        public MotorBikesService(IDeletableEntityRepository<MotorBike> motorBikeRepository)
        {
            this.motorBikeRepository = motorBikeRepository;
        }

        public async Task AddBike<T>(MotorBike motorBike)
        {
            await this.motorBikeRepository.AddAsync(motorBike);

            await this.motorBikeRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetFirstTree<T>()
        {
            return this.motorBikeRepository.All().Take(3).To<T>().ToList();
        }
    }
}
