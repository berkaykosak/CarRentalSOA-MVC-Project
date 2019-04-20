using CarRentalSOA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Entitites.Concrete
{
   public class Roller:IEntity
    {
        public int RolID { get; set; }
        public string RolAdi { get; set; }

    }
}
