namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ChatController : Controller
    {
        [Authorize]
        public IActionResult Chat()
        {
            return this.View();
        }
    }
}
