namespace MyMotoWorld.Web.ViewModels.MotorBike
{
    using System;
    using System.Collections.Generic;

    using MyMotoWorld.Services.Mapping;

    public class MotorBikeListViewModel : PagingViewModel
    {
        public IEnumerable<MotorBikeViewModel> MotorBikes { get; set; }
    }
}
