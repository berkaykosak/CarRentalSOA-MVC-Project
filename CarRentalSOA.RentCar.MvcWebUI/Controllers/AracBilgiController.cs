
using CarRentalSOA.RentCar.Business.Abstract;
using CarRentalSOA.RentCar.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSOA.RentCar.MvcWebUI.Controllers
{
    public class AracBilgiController: Controller

    {
        private AracBilgiService _aracBilgiService;

        public AracBilgiController(AracBilgiService aracBilgiService) 
        {
            _aracBilgiService = aracBilgiService;
        }

        public ActionResult Index()
        {
            var aracbilgis = _aracBilgiService.GetAll();

            AracBilgiListViewModel model = new AracBilgiListViewModel
            {
                aracbilgisi = aracbilgis
            };
            return View(model);
            // araçları listelerken başka şeyler de göndermek gerekebilir
            //bu açıdan encapsulation prensibiyle view modeli oluştururuz.
        }

    }
}
