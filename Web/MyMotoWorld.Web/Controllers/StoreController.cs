namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Collections.Generic;
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

        public IActionResult Index(string searchType, string searchString, int id = 1)
        {
            this.ViewData["CurrentFilter"] = searchString;
            this.ViewData["TypeFilter"] = searchType;

            IEnumerable<MotorBikeViewModel> motorBikes = null;


            if (!String.IsNullOrEmpty(searchString))
            {
                motorBikes = this.motorBikeService.GetAllSearchedBikes<MotorBikeViewModel>(id, 6, searchString);
            }
            else
            {
                motorBikes = this.motorBikeService.GetAllBikes<MotorBikeViewModel>(id, 6);
            }

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

        [Authorize]
        public async Task<IActionResult> AddToCart(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await this.motorBikeService.AddBikeToCart(id, userId);

            return this.RedirectToAction(nameof(this.Details), new { id = id });
        }
    }
}
