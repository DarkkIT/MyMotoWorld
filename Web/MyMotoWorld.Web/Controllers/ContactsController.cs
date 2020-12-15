﻿namespace MyMotoWorld.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyMotoWorld.Common;
    using MyMotoWorld.Services.Data.Contacts;
    using MyMotoWorld.Web.ViewModels.Massages;

    public class ContactsController : Controller
    {
        private readonly IContactsService contactsService;

        public ContactsController(IContactsService contactsService)
        {
            this.contactsService = contactsService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> NewMassage(NewMassageInputModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await this.contactsService.AddMassageAsync(input, userId);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
