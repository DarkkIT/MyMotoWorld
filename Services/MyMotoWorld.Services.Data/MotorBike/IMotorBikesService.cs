namespace MyMotoWorld.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MyMotoWorld.Models;

    public interface IMotorBikesService
    {
        IEnumerable<T> GetFirstTree<T>();
    }
}
