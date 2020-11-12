namespace MyMotoWorld.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Data;
    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Web.ViewModels;
    using MyMotoWorld.Web.ViewModels.Administration.Dashboard;
    using MyMotoWorld.Web.ViewModels.Home;
    using MyMotoWorld.Web.ViewModels.MotorBike;
    using MyMotoWorld.Web.ViewModels.Settings;

    public class HomeController : BaseController
    {
        private readonly IMotorBikesService motorBikesService;
        private readonly ApplicationDbContext db;

        public HomeController(IMotorBikesService motorBikesService, ApplicationDbContext db)
        {
            this.motorBikesService = motorBikesService;
            this.db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                BikeTypeCount = this.db.BikeTypes.Count(),
                EngineCount = this.db.Engines.Count(),
                ExtrasCount = this.db.Extras.Count(),
                MotorBikeCount = this.db.MotorBikes.Count(),
                MostLikedBike = this.db.MotorBikes.OrderByDescending(x => x.Liked).FirstOrDefault().Model,
                //MostLikedBike = "name",
                MostLikedType = this.db.BikeTypes.OrderByDescending(x => x.Liked).FirstOrDefault().Name,
                //MostLikedType = "name",
            };

            return this.View(viewModel);
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
