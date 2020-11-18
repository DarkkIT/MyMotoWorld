namespace MyMotoWorld.Web.ViewModels.Admins
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Microsoft.AspNetCore.Http;

    public class AddNewsInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime NewsDate { get; set; }

        public IFormFile Image { get; set; }
    }
}
