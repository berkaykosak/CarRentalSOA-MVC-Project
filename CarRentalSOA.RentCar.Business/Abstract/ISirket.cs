using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Abstract
{
   public  interface ISirket
    {
        List<Sirket> GetAll();
        void Add(Sirket sirket);
        void Update(Sirket sirket);
        void Delete(int sirketID);
    }
}
