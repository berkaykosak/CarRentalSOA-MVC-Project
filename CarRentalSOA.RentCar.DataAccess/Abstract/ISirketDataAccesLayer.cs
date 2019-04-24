using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.DataAccess.Abstract
{
    public interface ISirketDataAccesLayer : IEntityRepository<Sirket>
    {
        //SADECE SINIFA ÖZEL OPERASYONLAR YAZILABİLİR.
        void Add(Sirket sirket);
        void Delete(int sirketID);
        List<Sirket> GetList();
        void Update(Sirket sirket);
    }
}
