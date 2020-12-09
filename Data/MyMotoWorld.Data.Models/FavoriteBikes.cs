namespace MyMotoWorld.Data.Models
{
    using MyMotoWorld.Models;

    public class FavoriteBikes
    {
        public int Id { get; set; }

        public int MotorBikeId { get; set; }

        public virtual MotorBike MotorBike { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
