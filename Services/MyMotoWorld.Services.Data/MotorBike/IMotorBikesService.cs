namespace MyMotoWorld.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using MyMotoWorld.Models;
    using MyMotoWorld.Web.ViewModels.Admins;
    using MyMotoWorld.Web.ViewModels.MotorBike;

    public interface IMotorBikesService
    {
        Task AddBikeAsync(AddMotorBikeInputModel input);

        IEnumerable<MotorBikeViewModel> GetAllBikes<T>(int page, int itemsPerPage);

        MotorBikeFullInfoViewModel GetById<T>(int id);

        int GetCount();
    }
}
