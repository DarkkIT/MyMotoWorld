namespace MyMotoWorld.Web.ViewModels.Massages
{
    using System.Collections.Generic;

    public class ContactMessagesListViewModel : PagingViewModel
    {
        public IEnumerable<ContactMessagesViewModel> ContactMessages { get; set; }
    }
}
