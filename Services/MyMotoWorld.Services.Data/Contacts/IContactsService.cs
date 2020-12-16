namespace MyMotoWorld.Services.Data.Contacts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MyMotoWorld.Web.ViewModels.Massages;

    public interface IContactsService
    {
        Task AddMessageAsync(NewMessageInputModel input, string userId);

        IEnumerable<ContactMessagesViewModel> GetAllContactMessages<T>(int page, int itemsPerPage);

        int GetCount();
    }
}
