using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Abstract
{
    public interface IKullanicilarService
    {
        List<Kullanicilar> GetAll();
        void Add(Kullanicilar kullanicilar);
        void Update(Kullanicilar kullanicilar);
        void Delete(int kullanicilarID);
    }
}
