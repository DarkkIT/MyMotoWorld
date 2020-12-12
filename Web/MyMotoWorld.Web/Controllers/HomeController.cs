namespace MyMotoWorld.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Data;
    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Services.Data.Home;
    using MyMotoWorld.Services.Data.News;
    using MyMotoWorld.Web.ViewModels;
    using MyMotoWorld.Web.ViewModels.Home;
    using MyMotoWorld.Web.ViewModels.MotorBike;
    using MyMotoWorld.Web.ViewModels.News;

    public class HomeController : BaseController
    {
        private readonly IGetCountService getCountService;
        private readonly INewsService newsService;

        public HomeController(IGetCountService getCountService, INewsService newsService)
        {
            this.getCountService = getCountService;
            this.newsService = newsService;
        }

        public IActionResult Index()
        {
            var bikeModel = this.getCountService.GetCounts();
            var newsModel = this.newsService.GetLastThreeNews<NewsViewModel>();
            NewsListViewModel newsListModel = new NewsListViewModel
            {
                NewsList = newsModel,
            };

            CombinedViewModel viewModel = new CombinedViewModel
            {
                BikeInfo = bikeModel,
                NewsInfo = newsListModel,
            };

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

        public IActionResult Contacts()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult Favorites()
        {
            return this.View();
        }
    }
}
