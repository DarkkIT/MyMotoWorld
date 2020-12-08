namespace MyMotoWorld.Web.ViewModels.MotorBike
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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

        public double AvarageVote { get; set; }

        public string MainImagePath => "/images/bikes/" + this.Model + this.EngineCapacity + "-1" + ".jpg";

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<MotorBike, MotorBikeViewModel>().ForMember(
                m => m.EngineCapacity,
                opt => opt.MapFrom(x => x.Engine.EngineCapacity)).ForMember(
                m => m.EnginePower,
                opt => opt.MapFrom(x => x.Engine.EnginePower)).ForMember(
                m => m.BikeType,
                opt => opt.MapFrom(x => x.BikeType.Name)).ForMember(
                m => m.AvarageVote,
                opt => opt.MapFrom(x => x.Votes.Average(x => x.Value)));
        }
    }
}
