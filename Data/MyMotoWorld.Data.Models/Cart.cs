namespace MyMotoWorld.Data.Models
{
    using MyMotoWorld.Data.Common.Models;
    using MyMotoWorld.Models;

    public class Cart : BaseDeletableModel<int>
    {
        public int MotorBikeId { get; set; }

        public virtual MotorBike MotorBike { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal FullPrice { get; set; }

        public string Address { get; set; }
    }
}
