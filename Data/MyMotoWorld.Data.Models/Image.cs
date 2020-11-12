namespace MyMotoWorld.Data.Models
{
    using MyMotoWorld.Data.Common.Models;
    using MyMotoWorld.Models;

    public class Image : BaseDeletableModel<int>
    {
        public string Extension { get; set; }

        public int MotorBikeId { get; set; }

        public MotorBike MotorBike { get; set; }
    }
}
