namespace MyMotoWorld.Services.Data.Contacts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using MyMotoWorld.Web.ViewModels.Massages;

    public interface IContactsService
    {
        Task AddMassageAsync(NewMassageInputModel input, string userId);

        IEnumerable<ContactMassagesViewModel> GetAllContactMassages<T>(int page, int itemsPerPage);

        int GetCount();
    }
}
