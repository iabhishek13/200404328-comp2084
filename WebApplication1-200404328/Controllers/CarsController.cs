using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_200404328.Models;

namespace WebApplication1_200404328.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carList = new List<Car>()
       {
           new Car{Id=1, Brand="Toyota", Model="Carolla", Type= "Compact", Year = 2017},
           new Car{Id=2, Brand="Ford",Model="F-150", Type= "Truck", Year = 2018},
           new Car{Id=3, Brand="Dodge",Model="Caravan", Type= "Minivan", Year = 2019},
           new Car{Id=4, Brand="Honda",Model="Passport", Type= "SUV", Year = 2019}
       };

    public ActionResult Index()
    {
        return View(carList);
    }

        // GET: Details
        public ActionResult Detail(int? id)
        {
            if (id == null || id > carList.Count)
            {
                return Content("Car List");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }

    }
}