using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Abstract
{
    public interface IRollerService
    {
        List<Roller> GetAll();
        void Add(Roller roller);
        void Update(Roller roller);
        void Delete(int rolID);
    }
}
