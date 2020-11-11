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
        public string Name { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public string BikeType { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<MotorBike, MotorBikeViewModel>();
        }
    }
}
