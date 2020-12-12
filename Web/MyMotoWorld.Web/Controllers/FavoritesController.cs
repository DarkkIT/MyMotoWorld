namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Common;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Web.ViewModels.MotorBike;

    public class FavoritesController : Controller
    {
        private readonly IMotorBikesService motorBikeService;

        public FavoritesController(IMotorBikesService motorBikeService)
        {
            this.motorBikeService = motorBikeService;
        }

        [Authorize]
        public IActionResult Index(int id = 1)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var motorBikes = this.motorBikeService.GetAllFavoriteBikes<MotorBikeViewModel>(id, 6, userId);

            var viewModel = new MotorBikeListViewModel { MotorBikes = motorBikes, PageNumber = id, MotorBikeCount = this.motorBikeService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> RemoveFavorite(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await this.motorBikeService.RemoveBikeFromFavorit(id, userId);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
