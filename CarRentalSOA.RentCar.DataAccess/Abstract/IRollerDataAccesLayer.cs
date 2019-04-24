using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.DataAccess.Abstract
{
    public interface IRollerDataAccesLayer : IEntityRepository<Roller>
    {
        //SADECE SINIFA ÖZEL OPERASYONLAR YAZILABİLİR.
        List<Roller> GetList();
        void Add(Roller roller);
        void Delete(int rolID);
        void Update(Roller roller);
    }
}
