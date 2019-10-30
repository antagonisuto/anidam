using System;
using System.Collections.Generic;
using anidam.Data.Models;

namespace anidam.Data.interfaces
{
    public interface IAllCars
    {

        IEnumerable<Car> Cars {  get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int carId); 

    }
}
