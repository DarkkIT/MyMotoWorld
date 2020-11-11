﻿namespace MyMotoWorld.Models.Parts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RearBrake
    {
        public RearBrake()
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
