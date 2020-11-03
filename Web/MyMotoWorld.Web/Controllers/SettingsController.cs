namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Models;
    using MyMotoWorld.Services.Data;
    using MyMotoWorld.Web.ViewModels.Settings;

    public class SettingsController : BaseController
    {
        private readonly IMotorBikesService motorBikesService;

        private readonly IDeletableEntityRepository<MotorBike> repository;

        public SettingsController(IMotorBikesService motorBikesService, IDeletableEntityRepository<MotorBike> repository)
        {
            this.motorBikesService = motorBikesService;
            this.repository = repository;
        }

        public IActionResult About()
        {
            var motorBike = this.motorBikesService.GetAll<MotorBikeViewModel>();
            var model = new MotorBikeListViewModel { MotorBike = motorBike };
            return this.View(model);
        }

        //public async Task<IActionResult> InsertSetting()
        //{
        //    var random = new Random();
        //    var setting = new Setting { Name = $"Name_{random.Next()}", Value = $"Value_{random.Next()}" };

        //    await this.repository.AddAsync(setting);
        //    await this.repository.SaveChangesAsync();

        //    return this.RedirectToAction(nameof(this.Index));
        //}
    }
}
