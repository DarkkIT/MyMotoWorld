namespace MyMotoWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Models.Parts;

    public class MotorBike
    {
        public MotorBike()
        {
            this.Images = new HashSet<Image>();
            this.MotorBikeExtras = new HashSet<MotorBikeExtra>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        [Range(0, 2_000_000)]
        public int Price { get; set; }

        [Range(0, 1000)]
        public int Weight { get; set; }

        [Range(0, 10000)]
        public int Length { get; set; }

        [Range(0, 2000)]
        public int Height { get; set; }

        [Range(0, 2000)]
        public int SeatHeight { get; set; }

        public int BikeTypeId { get; set; }

        public virtual BikeType BikeType { get; set; }

        public int TransmissionId { get; set; }

        public virtual Transmission Transmission { get; set; }

        public int EngineId { get; set; }

        public virtual Engine Engine { get; set; }

        public int FrontSuspensionId { get; set; }

        public virtual FrontSuspension FrontSuspension { get; set; }

        public int RearSuspensionId { get; set; }

        public virtual RearSuspension RearSuspension { get; set; }

        public int FrontBrakesId { get; set; }

        public virtual FrontBrake FrontBrakes { get; set; }

        public int RearBrakesId { get; set; }

        public virtual RearBrake RearBrakes { get; set; }

        public string Descrition { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<MotorBikeExtra> MotorBikeExtras { get; set; }
    }
}
