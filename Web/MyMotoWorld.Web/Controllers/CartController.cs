namespace MyMotoWorld.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Web.ViewModels.Cart;
    using MyMotoWorld.Web.ViewModels.MotorBike;

    [Authorize]
    public class CartController : Controller
    {
        private readonly IMotorBikesService motorBikesService;

        public CartController(IMotorBikesService motorBikesService)
        {
            this.motorBikesService = motorBikesService;
        }

        public IActionResult Index(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var motorBikes = this.motorBikesService.GetAllCartBikes<MotorBikeViewModel>(id, 6, userId);

            var motorBikesList = new MotorBikeListViewModel { MotorBikes = motorBikes };

            CombinedCartViewModel viewModel = new CombinedCartViewModel
            {
                MotorBikes = motorBikesList,
                Input = new CartInputModel(),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> RemoveFromCart(int id, CartInputModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await this.motorBikesService.RemoveBikeFromCart(id, userId);

            return this.RedirectToAction(nameof(this.Index));
        }

        public IActionResult NextStep(CartInputModel input)
        {
            return this.View();
        }
    }
}
