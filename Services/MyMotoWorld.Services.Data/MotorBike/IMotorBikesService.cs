namespace MyMotoWorld.Services.Data
{
    using MyMotoWorld.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IMotorBikesService
    {
        IEnumerable<MotorBike> GetAll<MotorBike>();
    }
}
