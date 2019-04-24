using CarRentalSOA.Core.DataAccess.EntityFramework;
using CarRentalSOA.RentCar.DataAccess.Abstract;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.DataAccess.Concrete.EntityFramework
{
    public class EfSirketDataAccesLayer : EfEntityRepositoryBase<Sirket, CarRentalSOAContext>, ISirketDataAccesLayer
    {
        public void Delete(int sirketID)
        {
            throw new NotImplementedException();
        }

        public List<Sirket> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
