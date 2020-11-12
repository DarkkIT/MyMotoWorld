namespace MyMotoWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MotorBikeExtra
    {
        [Key]
        public int Id { get; set; }

        public int MotorBikeId { get; set; }

        public virtual MotorBike MotorBike { get; set; }

        public int ExtraId { get; set; }

        public virtual Extra Extra { get; set; }
    }
}
