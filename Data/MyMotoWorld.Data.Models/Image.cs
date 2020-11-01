using System.ComponentModel.DataAnnotations;

namespace MyMotoWorld.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte[] Name { get; set; }


        public int MotorBikeId { get; set; }
        public virtual MotorBike MotorBike { get; set; }
    }
}
