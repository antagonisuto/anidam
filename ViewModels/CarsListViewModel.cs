using System;
using System.Collections.Generic;
using anidam.Data.Models;

namespace anidam.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }

    }
}
