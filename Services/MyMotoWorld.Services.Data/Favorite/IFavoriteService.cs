namespace MyMotoWorld.Services.Data.Favorite
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IFavoriteService
    {
        bool IsAddedToFavorites(int id, string userId);
    }
}
