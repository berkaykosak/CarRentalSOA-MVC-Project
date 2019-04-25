using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CarRentalSOA.RentCar.Entitites.Concrete;

namespace CarRentalSOA.RentCar.MvcWebUI.Models
{
    public class AracBilgiListViewModel
    {
        public List<AracBilgi> aracbilgisi { get; set; }
    }
}
