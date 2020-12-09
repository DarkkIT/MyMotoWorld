namespace MyMotoWorld.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Common;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Web.ViewModels.MotorBike;

    public class StoreController : Controller
    {
        private readonly IMotorBikesService motorBikeService;

        public StoreController(IMotorBikesService motorBikeService)
        {
            this.motorBikeService = motorBikeService;
        }

        public IActionResult Index(int id = 1)
        {
            var motorBikes = this.motorBikeService.GetAllBikes<MotorBikeViewModel>(id, 6);

            var viewModel = new MotorBikeListViewModel { MotorBikes = motorBikes, PageNumber = id, MotorBikeCount = this.motorBikeService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var viewModel = this.motorBikeService.GetById<MotorBikeFullInfoViewModel>(id);

            return this.View(viewModel);
        }

        public async Task<IActionResult> AddToFavorite(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await this.motorBikeService.AddBikeToFavorit(id, userId);

            return this.RedirectToAction(nameof(this.Details), new { id = id });
        }
    }
}
