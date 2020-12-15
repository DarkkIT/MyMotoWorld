namespace MyMotoWorld.Web.ViewModels.Massages
{
    using System.Collections.Generic;

    public class ContactMassagesListViewModel : PagingViewModel
    {
        public IEnumerable<ContactMassagesViewModel> ContactMassages { get; set; }
    }
}
