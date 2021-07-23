using System;
using System.Collections.Generic;
using System.Text;

namespace MyMotoWorld.Web.ViewModels.Hub
{
    public class ResponseViewModel
    {
        public string User { get; set; }

        public string Message { get; set; }

        public string Date => DateTime.UtcNow.ToString();
    }
}
