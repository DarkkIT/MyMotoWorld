namespace MyMotoWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Data.Common.Models;

    public class Extra : BaseDeletableModel<int>
    {
        public Extra()
        {
            this.MotorBikeExtras = new HashSet<MotorBikeExtra>();
        }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public virtual ICollection<MotorBikeExtra> MotorBikeExtras { get; set; }
    }
}
