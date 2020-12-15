namespace MyMotoWorld.Web.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult NewMassage()
        {
            ////TODO: NewMassage.
            return this.View();
        }
    }
}
