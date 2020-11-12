namespace MyMotoWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Data.Common.Models;

    public class BikeType : BaseDeletableModel<int>
    {
        public BikeType()
        {
            this.MotorBikes = new HashSet<MotorBike>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Descrition { get; set; }

        public int Liked { get; set; }

        public virtual ICollection<MotorBike> MotorBikes { get; set; }
    }
}
