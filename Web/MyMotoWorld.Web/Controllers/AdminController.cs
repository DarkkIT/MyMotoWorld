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
    }
}
