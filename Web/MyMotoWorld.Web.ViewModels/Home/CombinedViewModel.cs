namespace MyMotoWorld.Web.ViewModels.Home
{
    using MyMotoWorld.Web.ViewModels.News;

    public class CombinedViewModel
    {
        public IndexViewModel BikeInfo { get; set; }

        public NewsListViewModel NewsInfo { get; set; }

        public string UserId { get; set; }
    }
}
