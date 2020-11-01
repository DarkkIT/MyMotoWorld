namespace MyMotoWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Transmission
    {
        public Transmission()
        {
            this.MotorBikes = new HashSet<MotorBike>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<MotorBike> MotorBikes { get; set; }
    }
}
