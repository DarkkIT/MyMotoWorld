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
            this.Images = new HashSet<Image>();
            this.MotorBikeExtras = new HashSet<MotorBikeExtra>();
            //this.Sales = new HashSet<Sale>();
        }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public int Weight { get; set; }

        public int Length { get; set; }

        public int Height { get; set; }

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

         //public virtual ICollection<Sale> Sales { get; set; }
    }
}
