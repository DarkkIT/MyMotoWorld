namespace MyMotoWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Extra
    {
        public Extra()
        {
            this.MotorBikeExtras = new HashSet<MotorBikeExtra>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public virtual ICollection<MotorBikeExtra> MotorBikeExtras { get; set; }
    }
}
