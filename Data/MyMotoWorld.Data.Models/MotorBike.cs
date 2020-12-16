namespace MyMotoWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Data.Common.Models;
    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Models.Parts;

    public class MotorBike : BaseDeletableModel<int>
    {
        public MotorBike()
        {
            this.MotorBikeExtras = new HashSet<MotorBikeExtra>();
            this.Sales = new HashSet<Sale>();
            this.Images = new HashSet<Image>();
            this.Votes = new HashSet<Vote>();
            this.FavoriteBikes = new HashSet<FavoriteBikes>();
            this.Carts = new HashSet<Cart>();
        }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Model { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int Liked { get; set; }

        [Required]
        public int Weight { get; set; }

        public int Quantity { get; set; }

        [Required]
        public int Length { get; set; }

        [Required]
        public int Height { get; set; }

        [Required]
        public int SeatHeight { get; set; }

        public int BikeTypeId { get; set; }

        public bool IsAddetToFavorit { get; set; }

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

        public virtual ICollection<MotorBikeExtra> MotorBikeExtras { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }

        public virtual ICollection<FavoriteBikes> FavoriteBikes { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
