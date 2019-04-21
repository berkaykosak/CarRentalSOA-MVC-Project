using CarRentalSOA.RentCar.Business.Abstract;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Concrete
{
    public class AracBilgiManager : AracBilgiService
    {
        private AracBilgiService aracBilgiService;
        public void Add(AracBilgi aracBilgi)
        {
            
        }

        public void Delete(int aracBilgiID)
        {
            throw new NotImplementedException();
        }

        public List<AracBilgi> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(AracBilgi aracBilgi)
        {
            throw new NotImplementedException();
        }
    }
}
