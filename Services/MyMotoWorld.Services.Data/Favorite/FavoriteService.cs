namespace MyMotoWorld.Services.Data.Favorite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MyMotoWorld.Data.Common.Repositories;
    using MyMotoWorld.Data.Models;

    public class FavoriteService : IFavoriteService
    {
        private readonly IRepository<FavoriteBikes> favoriteBikesRepository;

        public FavoriteService(IRepository<FavoriteBikes> favoriteBikesRepository)
        {
            this.favoriteBikesRepository = favoriteBikesRepository;
        }

        public bool IsAddedToFavorites(int id, string userId)
        {
            var isAdded = this.favoriteBikesRepository.All().Any(x => x.MotorBikeId == id && x.UserId == userId);

            return isAdded;
        }
    }
}
