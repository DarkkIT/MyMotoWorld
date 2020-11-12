namespace MyMotoWorld.Services.Data.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AutoMapper;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Mapping;

    public class PurchasedBike : IMapFrom<MotorBike>
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<MotorBike, PurchasedBike>();
        }
    }
}
