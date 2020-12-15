namespace MyMotoWorld.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Common;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Services.Data.Favorite;
    using MyMotoWorld.Web.ViewModels.MotorBike;

    public class StoreController : Controller
    {
        private readonly IMotorBikesService motorBikeService;
        private readonly IFavoriteService favoriteService;

        public StoreController(IMotorBikesService motorBikeService, IFavoriteService favoriteService)
        {
            this.motorBikeService = motorBikeService;
            this.favoriteService = favoriteService;
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

            string userId;
            if (this.User.Identity.IsAuthenticated)
            {
                userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            }
            else
            {
                userId = "UserNotLogged";
            }

            viewModel.IsAddetToFavorit = this.favoriteService.IsAddedToFavorites(id, userId);

            return this.View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> AddToFavorite(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await this.motorBikeService.AddBikeToFavorit(id, userId);

            return this.RedirectToAction(nameof(this.Details), new { id = id });
        }

        public IActionResult Chat()
        {
            return this.View();
        }
    }
}
