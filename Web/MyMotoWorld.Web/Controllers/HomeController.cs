namespace MyMotoWorld.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Data;
    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Services.Data.Home;
    using MyMotoWorld.Web.ViewModels;
    using MyMotoWorld.Web.ViewModels.Home;
    using MyMotoWorld.Web.ViewModels.MotorBike;

    public class HomeController : BaseController
    {
        private readonly IGetCountService getCountService;

        public HomeController(IGetCountService getCountService)
        {
            this.getCountService = getCountService;
        }

        public IActionResult Index()
        {
            var viewModel = this.getCountService.GetCounts();

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
