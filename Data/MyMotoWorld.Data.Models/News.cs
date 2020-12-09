namespace MyMotoWorld.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MyMotoWorld.Data.Common.Models;

    public class News : BaseDeletableModel<int>
    {
        public News()
        {
            this.FavoriteNews = new HashSet<FavoriteNews>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime NewsDate { get; set; }

        public string ImageName { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<FavoriteNews> FavoriteNews { get; set; }
    }
}
