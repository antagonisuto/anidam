using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using anidam.Data.interfaces;
using anidam.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace anidam.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat) {
            _allCars = iAllCars;
            _allCategories = iCarsCat;

        }

        public ViewResult List() {
            ViewBag.Title = "Pagw with automobiles";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Automobile";

            return View(obj);
        }
    }
}
