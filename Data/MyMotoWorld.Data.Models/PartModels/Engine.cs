using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMotoWorld.Models.Parts
{
    public class Engine
    {
        public Engine()
        {
            this.MotorBikes = new HashSet<MotorBike>();
        }


        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string Name { get; set; }


        public int EngineCapacity { get; set; }


        public int EnginePower { get; set; }


        public virtual ICollection<MotorBike> MotorBikes { get; set; }
    }
}
