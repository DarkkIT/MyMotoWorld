namespace MyMotoWorld.Models.Parts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Data.Common.Models;

    public class RearBrake : BaseDeletableModel<int>
    {
        public RearBrake()
        {
            this.MotorBikes = new HashSet<MotorBike>();
        }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<MotorBike> MotorBikes { get; set; }
    }
}
