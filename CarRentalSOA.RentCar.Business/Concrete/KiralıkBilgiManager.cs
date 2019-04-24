using CarRentalSOA.RentCar.Business.Abstract;
using CarRentalSOA.RentCar.DataAccess.Abstract;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Concrete
{
    public class KiralıkBilgiManager : IKiralıkBilgiService

     {
        private IKiralikBilgiDataAccesLayer _kiralilBilgiDataAccesLayer;

        public KiralıkBilgiManager(IKiralikBilgiDataAccesLayer kiralilBilgiDataAccesLayer )
        {
            _kiralilBilgiDataAccesLayer = kiralilBilgiDataAccesLayer;
        }

        public void Add(KiralikBilgi kiralıkBilgi)
        {
            _kiralilBilgiDataAccesLayer.Add(kiralıkBilgi);
        }

        public void Delete(int kiralıkBilgiID)
        {
            _kiralilBilgiDataAccesLayer.Delete(new KiralikBilgi { kiralıkID = kiralıkBilgiID });
        }

        public List<KiralikBilgi> GetAll()
        {
            return _kiralilBilgiDataAccesLayer.GetList(); 
            //listeleme koşulları getlist içerisinde belirtilebilir..
        }

        public void Update(KiralikBilgi kiralıkBilgi)
        {
            _kiralilBilgiDataAccesLayer.Update(kiralıkBilgi);
        }
    }
}
