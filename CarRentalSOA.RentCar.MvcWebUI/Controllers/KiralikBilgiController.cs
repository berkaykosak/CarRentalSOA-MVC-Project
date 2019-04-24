using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSOA.RentCar.MvcWebUI.Controllers
{
    public class KiralikBilgiController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
