namespace MyMotoWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Data.Common.Models;
    using MyMotoWorld.Data.Common.Repositories;

    public class Transmission : BaseDeletableModel<int>
    {
        public Transmission()
        {
            this.MotorBikes = new HashSet<MotorBike>();
        }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<MotorBike> MotorBikes { get; set; }
    }
}
