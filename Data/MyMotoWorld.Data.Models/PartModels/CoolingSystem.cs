namespace MyMotoWorld.Models.Parts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMotoWorld.Data.Common.Models;

    public class CoolingSystem : BaseDeletableModel<int>
    {
        public CoolingSystem()
        {
            this.Engines = new HashSet<Engine>();
        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Engine> Engines { get; set; }
    }
}
