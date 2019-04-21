using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Abstract
{
    public interface IKiralıkBilgiService
    {
        List<KiralikBilgi> GetAll();
        void Add(KiralikBilgi kiralıkBilgi);
        void Update(KiralikBilgi kiralıkBilgi);
        void Delete(int kiralıkBilgiID);
    }
}
