namespace MyMotoWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Models.Parts;

    public class CoolingSystem
    {
        public CoolingSystem()
        {
            this.Engines = new HashSet<Engine>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Engine> Engines { get; set; }
    }
}
