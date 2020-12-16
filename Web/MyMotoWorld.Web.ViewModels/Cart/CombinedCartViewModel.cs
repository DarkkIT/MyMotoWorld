namespace MyMotoWorld.Web.ViewModels.Cart
{
    using MyMotoWorld.Web.ViewModels.MotorBike;

    public class CombinedCartViewModel
    {
        public MotorBikeListViewModel MotorBikes { get; set; }

        public CartInputModel Input { get; set; }
    }
}
