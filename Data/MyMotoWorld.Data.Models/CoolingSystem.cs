using MyMotoWorld.Models.Parts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMotoWorld.Models
{
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
