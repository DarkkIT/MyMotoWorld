namespace MyMotoWorld.Data.Models
{
    using MyMotoWorld.Data.Common.Models;
    using MyMotoWorld.Models;

    public class FavoriteBikes : BaseModel<int>
    {
        public int MotorBikeId { get; set; }

        public virtual MotorBike MotorBike { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
