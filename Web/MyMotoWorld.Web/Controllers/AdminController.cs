namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Web.ViewModels.Admins;

    public class AdminController : Controller
    {
        private readonly IMotorBikesService motorBikesService;

        private readonly IWebHostEnvironment webHostEnvironment;

        public AdminController(IWebHostEnvironment webHostEnvironment, IMotorBikesService motorBikesService)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.motorBikesService = motorBikesService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult AddBike()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBike(AddMotorBikeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            if (input.Image != null)
            {
                using (FileStream fs = new FileStream(this.webHostEnvironment.WebRootPath + ("/images/bikes/" + input.Model + ".png"), FileMode.Create))
                {
                    await input.Image.CopyToAsync(fs);
                }
            }

            await this.motorBikesService.AddBikeAsync(input);

            return this.RedirectToAction(nameof(this.Success));
        }

        public IActionResult AddNews()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult AddNews(AddNewsInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return this.RedirectToAction(nameof(this.Success));
        }

        public IActionResult Success()
        {
            return this.View();
        }
    }
}
