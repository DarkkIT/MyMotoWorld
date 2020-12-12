namespace MyMotoWorld.Web.ViewModels.MotorBike
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Mapping;

    public class MotorBikeFullInfoViewModel : IMapFrom<MotorBike>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public int Liked { get; set; }

        public int Weight { get; set; }

        public int Length { get; set; }

        public int Height { get; set; }

        public int SeatHeight { get; set; }

        public string BikeType { get; set; }

        public string BikeTypeDesctiption { get; set; }

        public int EnginePower { get; set; }

        public string EngineName { get; set; }

        public int EngineCapacity { get; set; }

        public string Transmission { get; set; }

        public string FrontSuspension { get; set; }

        public string RearSuspension { get; set; }

        public string FrontBrakes { get; set; }

        public string RearBrakes { get; set; }

        public string CoolingSystem { get; set; }

        public string Descrition { get; set; }

        public double AverageVote { get; set; }

        public bool IsAddetToFavorit { get; set; }

        public string MainImagePath => "/images/bikes/" + this.Model + this.EngineCapacity + "-1" + ".jpg";

        public string SecondImagePath => "/images/bikes/" + this.Model + this.EngineCapacity + "-2" + ".jpg";

        public string ThirdImagePath => "/images/bikes/" + this.Model + this.EngineCapacity + "-3" + ".jpg";

        public List<string> ImagesList => new List<string> { "/images/bikes/" + this.Model + this.EngineCapacity + "-1" + ".jpg", "/images/bikes/" + this.Model + this.EngineCapacity + "-1" + ".jpg", "/images/bikes/" + this.Model + this.EngineCapacity + "-1" + ".jpg" };

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<MotorBike, MotorBikeFullInfoViewModel>().ForMember(
                m => m.EngineCapacity,
                opt => opt.MapFrom(x => x.Engine.EngineCapacity)).ForMember(
                m => m.EnginePower,
                opt => opt.MapFrom(x => x.Engine.EnginePower)).ForMember(
                m => m.EngineName,
                opt => opt.MapFrom(x => x.Engine.Name)).ForMember(
                m => m.Transmission,
                opt => opt.MapFrom(x => x.Transmission.Name)).ForMember(
                m => m.FrontSuspension,
                opt => opt.MapFrom(x => x.FrontSuspension.Name)).ForMember(
                m => m.RearSuspension,
                opt => opt.MapFrom(x => x.RearSuspension.Name)).ForMember(
                m => m.FrontBrakes,
                opt => opt.MapFrom(x => x.FrontBrakes.Name)).ForMember(
                m => m.RearBrakes,
                opt => opt.MapFrom(x => x.RearBrakes.Name)).ForMember(
                m => m.CoolingSystem,
                opt => opt.MapFrom(x => x.Engine.CoolingSystem.Name)).ForMember(
                m => m.BikeType,
                opt => opt.MapFrom(x => x.BikeType.Name)).ForMember(
                m => m.AverageVote,
                opt => opt.MapFrom(x => x.Votes.Average(x => x.Value))).ForMember(
                m => m.BikeTypeDesctiption,
                opt => opt.MapFrom(x => x.BikeType.Descrition));
        }
    }
}
