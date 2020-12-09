namespace MyMotoWorld.Data.Models
{
    using MyMotoWorld.Data.Common.Models;

    public class FavoriteNews : BaseDeletableModel<int>
    {
        public int NewsId { get; set; }

        public virtual News News { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
