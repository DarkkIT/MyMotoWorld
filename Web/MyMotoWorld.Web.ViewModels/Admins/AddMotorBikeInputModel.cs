namespace MyMotoWorld.Web.ViewModels.Admins
{
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Mapping;

    public class AddMotorBikeInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Range(1, 1000)]
        public int Weight { get; set; }

        [Required]
        [Range(1, 300)]
        public int Length { get; set; }

        [Required]
        [Range(1, 200)]
        public int Height { get; set; }

        [Required]
        [Range(1, 120)]
        public int SeatHeight { get; set; }

        [Required]
        [MaxLength(100)]
        public string BikeType { get; set; }

        [Required]
        [MaxLength(2000)]
        public string BikeTypeDesctiption { get; set; }

        [Required]
        [MaxLength(200)]
        public string EngineName { get; set; }

        [Required]
        [Range(1, 5000)]
        public int EngineCapacity { get; set; }

        [Required]
        [Range(1, 1000)]
        public int EnginePower { get; set; }

        [Required]
        [MaxLength(100)]
        public string EngineCoolingSystemName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Transmission { get; set; }

        [Required]
        [MaxLength(200)]
        public string FrontSuspension { get; set; }

        [Required]
        [MaxLength(200)]
        public string RearSuspension { get; set; }

        [Required]
        [MaxLength(200)]
        public string FrontBrakes { get; set; }

        [Required]
        [MaxLength(200)]
        public string RearBrakes { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Descrition { get; set; }

        public IFormFile Image { get; set; }
    }
}
