namespace MyMotoWorld.Models
{
    using System.ComponentModel.DataAnnotations;

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
