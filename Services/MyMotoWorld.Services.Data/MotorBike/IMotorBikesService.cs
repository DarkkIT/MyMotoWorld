namespace MyMotoWorld.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using MyMotoWorld.Models;

    public interface IMotorBikesService
    {
        IEnumerable<T> GetFirstTree<T>();

        async Task AddBike<T>(MotorBike motorBike)
        {
        }
    }
}
