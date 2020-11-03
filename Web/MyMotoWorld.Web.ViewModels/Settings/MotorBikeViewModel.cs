namespace MyMotoWorld.Web.ViewModels.Settings
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AutoMapper;
    using MyMotoWorld.Models;

    public class MotorBikeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string BikeType { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<MotorBike, MotorBikeViewModel>();
        }
    }
}
