using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMotoWorld.Models
{
    public class BikeType
    {
        public BikeType()
        {
            this.MotorBikes = new HashSet<MotorBike>();
        }


        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string Name { get; set; }


        public string Descrition { get; set; }


        public virtual ICollection<MotorBike> MotorBikes { get; set; }
    }
}
