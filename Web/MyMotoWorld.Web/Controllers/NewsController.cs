namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Common;
    using MyMotoWorld.Services.Data.News;
    using MyMotoWorld.Web.ViewModels.News;

    public class NewsController : Controller
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        public IActionResult Index(int id = 1)
        {
            var news = this.newsService.GetAllNews<NewsViewModel>(id, 6);

            var viewModel = new NewsListViewModel { NewsList = news, PageNumber = id, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult NewsDetails(int id)
        {
            var viewModel = this.newsService.GetById<NewsViewModel>(id);

            return this.View(viewModel);
        }
    }
}
