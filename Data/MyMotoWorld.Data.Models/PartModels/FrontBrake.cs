using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMotoWorld.Models.Parts
{
    public class FrontBrake
    {
        public FrontBrake()
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
