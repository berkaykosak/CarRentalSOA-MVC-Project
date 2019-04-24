using CarRentalSOA.Core.DataAccess;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.DataAccess.Abstract
{
    public interface IKullanicilarDataAccesLayer : IEntityRepository<Kullanicilar>
    {
        //SADECE SINIFA ÖZEL OPERASYONLAR YAZILABİLİR.
        void Add(Kullanicilar kullanicilar);
        void Delete(int kullanicilarID);
        List<Kullanicilar> GetList();
        void Update(Kullanicilar kullanicilar);
    }
}
