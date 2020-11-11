namespace MyMotoWorld.Web.ViewModels.Admins
{
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;

    using MyMotoWorld.Models;

    public class AddMotorBikeInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]

        public int Weight { get; set; }

        [Required]

        public int Length { get; set; }

        [Required]

        public int Height { get; set; }

        [Required]

        public int SeatHeight { get; set; }

        [Required]
        [MaxLength(100)]
        public string BikeType { get; set; }

        [Required]
        [MaxLength(2000)]
        public string BikeTypeDesctiption { get; set; }

        [Required]
        [MaxLength(100)]
        public string EngineName { get; set; }

        [Required]

        public int EngineCapacity { get; set; }

        [Required]

        public int EnginePower { get; set; }

        [Required]
        [MaxLength(100)]
        public string EngineCoolingSystemName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Transmission { get; set; }

        [Required]
        [MaxLength(100)]
        public string FrontSuspension { get; set; }

        [Required]
        [MaxLength(100)]
        public string RearSuspension { get; set; }

        [Required]
        [MaxLength(100)]
        public string FrontBrakes { get; set; }

        [Required]
        [MaxLength(100)]
        public string RearBrakes { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Descrition { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<MotorBike, AddMotorBikeInputModel>().ForMember(
                m => m.BikeType,
                opt => opt.MapFrom(x => x.BikeType.Name)).ForMember(
                m => m.BikeTypeDesctiption,
                opt => opt.MapFrom(x => x.BikeType.Descrition)).ForMember(
                m => m.EngineName,
                opt => opt.MapFrom(x => x.Engine.Name)).ForMember(
                m => m.EngineCapacity,
                opt => opt.MapFrom(x => x.Engine.EngineCapacity)).ForMember(
                m => m.EnginePower,
                opt => opt.MapFrom(x => x.Engine.EnginePower)).ForMember(
                m => m.EngineCoolingSystemName,
                opt => opt.MapFrom(x => x.Engine.CoolingSystem.Name)).ForMember(
                m => m.Transmission,
                opt => opt.MapFrom(x => x.Transmission.Name)).ForMember(
                m => m.FrontSuspension,
                opt => opt.MapFrom(x => x.FrontSuspension.Name)).ForMember(
                m => m.RearSuspension,
                opt => opt.MapFrom(x => x.RearSuspension.Name)).ForMember(
                m => m.FrontBrakes,
                opt => opt.MapFrom(x => x.FrontBrakes.Name)).ForMember(
                m => m.RearBrakes,
                opt => opt.MapFrom(x => x.RearBrakes.Name));
        }
    }
}
