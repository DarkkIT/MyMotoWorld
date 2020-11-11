namespace MyMotoWorld.Models.Parts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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

        public int CoolingSystemId { get; set; }

        public CoolingSystem CoolingSystem { get; set; }

        public virtual ICollection<MotorBike> MotorBikes { get; set; }
    }
}
