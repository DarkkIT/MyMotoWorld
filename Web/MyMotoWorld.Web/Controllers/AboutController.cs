namespace MyMotoWorld.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class AboutController : Controller
    {
        // GET: AboutController
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
