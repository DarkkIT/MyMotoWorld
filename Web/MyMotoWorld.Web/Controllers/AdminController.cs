namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using MyMotoWorld.Common;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Services.Data.News;
    using MyMotoWorld.Web.ViewModels.Admins;
    using MyMotoWorld.Web.ViewModels.MotorBike;
    using MyMotoWorld.Web.ViewModels.News;

    public class AdminController : Controller
    {
        private readonly IMotorBikesService motorBikesService;
        private readonly INewsService newsService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AdminController(IWebHostEnvironment webHostEnvironment, IMotorBikesService motorBikesService, INewsService newsService)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.motorBikesService = motorBikesService;
            this.newsService = newsService;
        }

        [Authorize]
        public IActionResult Index()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult AddBike()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddBike(AddMotorBikeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            if (input.Image != null)
            {
                using (FileStream fs = new FileStream(this.webHostEnvironment.WebRootPath + ("/images/bikes/" + input.Model + input.EngineCapacity + "-1" + ".jpg"), FileMode.Create))
                {
                    await input.Image.CopyToAsync(fs);
                }
            }

            await this.motorBikesService.AddBikeAsync(input);

            return this.RedirectToAction(nameof(this.Success));
        }

        [Authorize]
        public IActionResult AddNews()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddNews(AddNewsInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            if (input.Image != null && input.Image.Length > 0)
            {
                using (FileStream fs = new FileStream(this.webHostEnvironment.WebRootPath + ("/images/news/" + input.ImageName + ".jpg"), FileMode.Create))
                {
                    await input.Image.CopyToAsync(fs);
                }
            }

            await this.newsService.AddNewsAsync(input);

            return this.RedirectToAction(nameof(this.Success));
        }

        [Authorize]
        public IActionResult Success()
        {
            return this.View();
        }

        public IActionResult AllBikes()
        {
            var motorBikes = this.motorBikesService.GetAllBikes<MotorBikeViewModel>(1, 1000);
            var viewModel = new MotorBikeListViewModel { MotorBikes = motorBikes, PageNumber = 1, MotorBikeCount = this.motorBikesService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult EditBike(int id)
        {
            var viewModel = this.motorBikesService.GetById<MotorBikeFullInfoViewModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditBike(EditBikeInputModel input, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.motorBikesService.EditBikeAsync(input, id);

            return this.RedirectToAction(nameof(this.Success));
        }

        public IActionResult AllNews()
        {
            var newses = this.newsService.GetAllNews<NewsViewModel>(1, 1000);
            var viewModel = new NewsListViewModel { NewsList = newses, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult EditNews(int id)
        {
            var viewModel = this.newsService.GetById<NewsViewModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditNews(EditNewsInputModel input, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.newsService.EditNewsAsync(input, id);

            return this.RedirectToAction(nameof(this.Success));
        }

        public IActionResult DeleteBike(int id)
        {
            if (this.motorBikesService.DeleteBike(id))
            {
                return this.RedirectToAction(nameof(this.Success));
            }

            return this.RedirectToAction(nameof(this.AllBikes));
        }

        public IActionResult DeleteNews(int id)
        {
            if (this.newsService.DeleteNews(id))
            {
                return this.RedirectToAction(nameof(this.Success));
            }

            return this.RedirectToAction(nameof(this.AllBikes));
        }
    }
}
