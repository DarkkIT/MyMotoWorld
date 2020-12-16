namespace MyMotoWorld.Web.Hubs
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.SignalR;
    using MyMotoWorld.Data.Models;

    [Authorize]
    public class ChatHub : Hub
    {
        public async Task Send(string massage)
        {
            await this.Clients.All.SendAsync(
                "NewMassage",
                new Message { User = this.Context.User.Identity.Name, Text = massage });
        }
    }
}
