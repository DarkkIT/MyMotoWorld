namespace MyMotoWorld.Services.Data.Home
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MyMotoWorld.Web.ViewModels.Home;

    public interface IGetCountService
    {
        IndexViewModel GetCounts();
    }
}
