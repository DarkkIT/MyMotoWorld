using System.ComponentModel.DataAnnotations;

namespace MyMotoWorld.Models
{
    public class MotorBikeExtra
    {
        [Key]
        public int Id { get; set; }


        public int MotorBikdeId { get; set; }
        public virtual MotorBike MotorBike { get; set; }


        public int ExtraId { get; set; }
        public virtual Extra Extra { get; set; }
    }
}
