namespace MyMotoWorld.Data.Models
{
    public class FavoriteNews
    {
        public int Id { get; set; }

        public int NewsId { get; set; }

        public virtual News News { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
