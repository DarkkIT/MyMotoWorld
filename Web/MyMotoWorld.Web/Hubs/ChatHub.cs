namespace MyMotoWorld.Web.Hubs
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.SignalR;
    using MyMotoWorld.Data.Models;
    using MyMotoWorld.Web.ViewModels.Hub;

    [Authorize]
    public class ChatHub : Hub
    {
        private readonly UserManager<ApplicationUser> userManager;

        public ChatHub(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task Send(ChatInputViewModel data)
        {
            var userName = this.Context.User.Identity.Name;

            var response = new ResponseViewModel()
            {
                Message = data.Content,
                User = userName,
            };

            var userId = this.Context.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await this.Clients.Users("90c104b6-75c2-4819-af7a-faaa269de847", userId).SendAsync("ReceiveMessage", response);
        }
    }
}
