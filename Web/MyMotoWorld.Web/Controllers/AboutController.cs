namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
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
