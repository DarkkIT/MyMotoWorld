namespace MyMotoWorld.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using MyMotoWorld.Data.Common.Models;
    using MyMotoWorld.Models;

    public class Sale : BaseDeletableModel<int>
    {
        public Sale()
        {
            this.PurchasedBikes = new HashSet<MotorBike>();
        }

        public decimal TotalPrice { get; set; }

        [NotMapped]
        public ICollection<MotorBike> PurchasedBikes { get; set; }

        public int MotorBikeId { get; set; }

        public virtual MotorBike MotorBike { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
