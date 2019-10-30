using System;
using System.Collections.Generic;
using System.Linq;
using anidam.Data.interfaces;
using anidam.Data.Models;

namespace anidam.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory(); 

        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Fast one",
                        longDesc = "Smart, beauty and guite car from Tesla",
                        img = "/img/1.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Calm and quite",
                        longDesc = "Comfortable car for city",
                        img = "/img/2.jpg",
                        price = 11000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "BMW M3",
                        shortDesc = "Big and cozy",
                        longDesc = "Comfortable car for city",
                        img = "/img/3.png",
                        price = 65000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mersedes C Class",
                        shortDesc = "Big and cozy",
                        longDesc = "Comfortable car for city",
                        img = "/img/4.jpg",
                        price = 40000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Nissan Leaf",
                        shortDesc = "Economic and no sound",
                        longDesc = "Comfortable car for city",
                        img = "/img/5.jpg",
                        price = 14000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
