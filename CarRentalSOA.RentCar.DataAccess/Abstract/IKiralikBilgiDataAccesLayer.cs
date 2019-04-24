using CarRentalSOA.Core.DataAccess;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.DataAccess.Abstract
{
    public interface IKiralikBilgiDataAccesLayer : IEntityRepository<KiralikBilgi>
    {
        //SADECE SINIFA ÖZEL OPERASYONLAR YAZILABİLİR.
        List<KiralikBilgi> GetList();
        void Add(KiralikBilgi kiralıkBilgi);
        void Update(KiralikBilgi kiralıkBilgi);
        void Delete(int kiralıkBilgiID);
        void Delete(KiralikBilgi kiralikBilgi);
    }
}
