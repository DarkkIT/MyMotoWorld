namespace MyMotoWorld.Web.ViewModels.MotorBike
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AutoMapper;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Mapping;

    public class MotorBikeViewModel : IMapFrom<MotorBike>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string BikeType { get; set; }

        public int EnginePower { get; set; }

        public int EngineCapacity { get; set; }

        public int Liked { get; set; }

        public string ImagePath => "/images/bikes/" + this.Model + this.EngineCapacity + ".jpg";

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<MotorBike, MotorBikeViewModel>().ForMember(
                m => m.EngineCapacity,
                opt => opt.MapFrom(x => x.Engine.EngineCapacity)).ForMember(
                m => m.EnginePower,
                opt => opt.MapFrom(x => x.Engine.EnginePower));
        }
    }
}
