namespace MyMotoWorld.Models.Parts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Data.Common.Models;

    public class FrontSuspension : BaseDeletableModel<int>
    {
        public FrontSuspension()
        {
            this.MotorBikes = new HashSet<MotorBike>();
        }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<MotorBike> MotorBikes { get; set; }
    }
}
