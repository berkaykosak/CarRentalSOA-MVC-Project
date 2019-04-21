using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Abstract
{
    public interface AracBilgiService
    {
        //istenilen operasyonları servis interface içine yani buraya yazıyoruz...

        List<AracBilgi> GetAll();
        void Add(AracBilgi aracBilgi);
        void Update(AracBilgi aracBilgi);
        void Delete(int aracBilgiID);

    }
}
