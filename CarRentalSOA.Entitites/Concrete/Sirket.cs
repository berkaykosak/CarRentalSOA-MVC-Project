using CarRentalSOA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Entitites.Concrete
{
    public class Sirket:IEntity
    {
        public int sirketID { get; set; }
        public string sirketAdi { get; set; }
        public string sirketSehri { get; set; }
        public string sirketAdresi { get; set; }
        public int sirketAracSayisi { get; set; }

    }
}
