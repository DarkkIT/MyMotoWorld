namespace MyMotoWorld.Web.Controllers
{
    using System.IO;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Common;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Services.Data.Contacts;
    using MyMotoWorld.Services.Data.News;
    using MyMotoWorld.Web.ViewModels.Admins;
    using MyMotoWorld.Web.ViewModels.Massages;
    using MyMotoWorld.Web.ViewModels.MotorBike;
    using MyMotoWorld.Web.ViewModels.News;

    [Authorize(Roles = "Master")]
    public class AdminController : Controller
    {
        private readonly IMotorBikesService motorBikesService;
        private readonly INewsService newsService;
        private readonly IContactsService contactsService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AdminController(IWebHostEnvironment webHostEnvironment, IMotorBikesService motorBikesService, INewsService newsService, IContactsService contactsService)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.motorBikesService = motorBikesService;
            this.newsService = newsService;
            this.contactsService = contactsService;
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
                using (FileStream fs = new FileStream(this.webHostEnvironment.WebRootPath + ("/images/bikes/" + input.Model + input.EngineCapacity + "-1" + ".jpg"), FileMode.Create))
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

        public IActionResult Success()
        {
            return this.View();
        }

        public IActionResult AllBikes()
        {
            var motorBikes = this.motorBikesService.GetAllBikesWithDeleted<MotorBikeViewModel>(1, 1000);
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
            var newses = this.newsService.GetAllNewsWithDeleted<NewsViewModel>(1, 1000);
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

        public async Task<IActionResult> DeleteBike(int id)
        {
            await this.motorBikesService.DeleteBike(id);

            return this.RedirectToAction(nameof(this.AllBikes));
        }

        public async Task<IActionResult> DeleteNews(int id)
        {
            await this.newsService.DeleteNews(id);

            return this.RedirectToAction(nameof(this.AllNews));
        }

        public async Task<IActionResult> UnDeleteBike(int id)
        {
            await this.motorBikesService.UnDeleteBike(id);

            return this.RedirectToAction(nameof(this.AllBikes));
        }

        public async Task<IActionResult> UnDeleteNews(int id)
        {
            await this.newsService.UnDeleteNews(id);

            return this.RedirectToAction(nameof(this.AllNews));
        }

        public IActionResult AllMassages()
        {
            var contactMassages = this.contactsService.GetAllContactMassages<ContactMassagesViewModel>(1, 1000);
            var viewModel = new ContactMassagesListViewModel { ContactMassages = contactMassages, PageNumber = 1, MotorBikeCount = this.contactsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }
    }
}
