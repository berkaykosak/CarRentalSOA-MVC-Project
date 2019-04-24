using CarRentalSOA.RentCar.Business.Abstract;
using CarRentalSOA.RentCar.DataAccess.Abstract;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Concrete
{
    public class AracBilgiManager : AracBilgiService
    {
        private IAracBilgiDataAccesLayer _aracBilgiDataAccesLayer;

        public AracBilgiManager(IAracBilgiDataAccesLayer aracBilgiDataAccesLayer)
        {
            _aracBilgiDataAccesLayer = aracBilgiDataAccesLayer;
        }

        public List<AracBilgi> GetAll()
        {
            return _aracBilgiDataAccesLayer.GetList();
            //bu kısımlarda istediğimiz sorguları gönderebiliriz
            // GetbyID numarası diyip ID numarasına göre sorgulama yapabiliriz....

        }

        public void Add(AracBilgi aracBilgi)
        {
            _aracBilgiDataAccesLayer.Add(aracBilgi);
            
        }

        public void Delete(int aracBilgiID)
        {
            _aracBilgiDataAccesLayer.Delete(new AracBilgi {aracID = aracBilgiID } );
        }

       

        public void Update(AracBilgi aracBilgi)
        {
            _aracBilgiDataAccesLayer.Update(aracBilgi);
        }
    }
}
