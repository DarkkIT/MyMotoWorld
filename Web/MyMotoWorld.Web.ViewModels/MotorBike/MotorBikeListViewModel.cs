namespace MyMotoWorld.Web.ViewModels.MotorBike
{
    using System.Collections.Generic;

    using MyMotoWorld.Services.Mapping;

    public class MotorBikeListViewModel
    {
        public IEnumerable<MotorBikeViewModel> MotorBikes { get; set; }
    }
}
