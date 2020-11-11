namespace MyMotoWorld.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Web.ViewModels;
    using MyMotoWorld.Web.ViewModels.MotorBike;
    using MyMotoWorld.Web.ViewModels.Settings;

    public class HomeController : BaseController
    {
        private readonly IMotorBikesService motorBikesService;

        public HomeController(IMotorBikesService motorBikesService)
        {
            this.motorBikesService = motorBikesService;
        }

        public IActionResult Index()
        {
            var motorBikes = this.motorBikesService.GetFirstTree<MotorBikeViewModel>();
            var model = new MotorBikeListViewModel { MotorBikes = motorBikes };

            return this.View(model);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
