namespace MyMotoWorld.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ChatController : Controller
    {
        [Authorize(Roles = "Master")]
        public IActionResult Chat()
        {
            return this.View();
        }
    }
}
