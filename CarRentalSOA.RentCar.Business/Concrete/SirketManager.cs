using CarRentalSOA.RentCar.Business.Abstract;
using CarRentalSOA.RentCar.DataAccess.Abstract;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Concrete
{
    public class SirketManager : ISirket
    {
        private ISirketDataAccesLayer _sirketDataAccesLayer;

        public SirketManager(ISirketDataAccesLayer sirketDataAccesLayer)
        {
            _sirketDataAccesLayer = sirketDataAccesLayer;
        }

        public void Add(Sirket sirket)
        {
            _sirketDataAccesLayer.Add(sirket);

        }

        public void Delete(int sirketID)
        {
            _sirketDataAccesLayer.Delete(sirketID);
        }

        public List<Sirket> GetAll()
        {
           return  _sirketDataAccesLayer.GetList();
        }

        public void Update(Sirket sirket)
        {
            _sirketDataAccesLayer.Update(sirket);

        }
    }
}
