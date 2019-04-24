using CarRentalSOA.RentCar.Business.Abstract;
using CarRentalSOA.RentCar.DataAccess.Abstract;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Concrete
{
   public  class RollerManager : IRollerService
    {
        private IRollerDataAccesLayer _rollerDataAccesLayer;

        public RollerManager(IRollerDataAccesLayer rollerDataAccesLayer)
        {
            _rollerDataAccesLayer = rollerDataAccesLayer;
        }

        public void Add(Roller roller)
        {
            _rollerDataAccesLayer.Add(roller);
        }

        public void Delete(int rolID)
        {
            _rollerDataAccesLayer.Delete(rolID);
        }

        public List<Roller> GetAll()
        {
            return _rollerDataAccesLayer.GetList();

        }

        public void Update(Roller roller)
        {
            _rollerDataAccesLayer.Update(roller);
        }
    }
}
