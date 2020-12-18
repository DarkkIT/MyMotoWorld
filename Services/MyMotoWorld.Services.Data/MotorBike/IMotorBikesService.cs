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

        Task EditBikeAsync(EditBikeInputModel input, int id);

        IEnumerable<MotorBikeViewModel> GetAllBikes<T>(int page, int itemsPerPage);

        IEnumerable<MotorBikeViewModel> GetAllSearchedBikes<T>(int page, int itemsPerPage, string searchString);

        IEnumerable<MotorBikeViewModel> GetAllFavoriteBikes<T>(int page, int itemsPerPage, string userId);

        IEnumerable<MotorBikeViewModel> GetAllBikesWithDeleted<T>(int page, int itemsPerPage);

        MotorBikeFullInfoViewModel GetById<T>(int id);

        int GetCount();

        Task DeleteBike(int id);

        Task UnDeleteBike(int id);

        Task AddBikeToFavorit(int id, string userId);

        Task RemoveBikeFromFavorit(int id, string userId);

        Task AddBikeToCart(int id, string userId);

        Task RemoveBikeFromCart(int id, string userId);

        IEnumerable<MotorBikeViewModel> GetAllCartBikes<T>(int page, int itemsPerPage, string userId);
    }
}
