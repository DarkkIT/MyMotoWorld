//namespace MyMotoWorld.Data.Models
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Linq;
//    using System.Text;

//    using MyMotoWorld.Data;
//    using MyMotoWorld.Data.Common.Models;
//    using MyMotoWorld.Models;

//    public class Sale : BaseDeletableModel<int>
//    {
//        public Sale()
//        {
//            this.MotorBikes = new HashSet<MotorBike>();
//        }

//        public int TotalPrice { get; set; }

//        [ForeignKey(nameof(MotorBike))]
//        public int MotorBikeId { get; set; }

//        public virtual MotorBike MotorBike { get; set; }

//        [ForeignKey(nameof(ApplicationUser))]
//        public string ApplicationUserId { get; set; }

//        public virtual ApplicationUser User { get; set; }

//        public virtual ICollection<MotorBike> MotorBikes { get; set; }
//    }
//}
