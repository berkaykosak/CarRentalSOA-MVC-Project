﻿using CarRentalSOA.Core.DataAccess.EntityFramework;
using CarRentalSOA.RentCar.DataAccess.Abstract;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.DataAccess.Concrete.EntityFramework
{
    public class EfRollerDataAccesLayer : EfEntityRepositoryBase<Roller, CarRentalSOAContext>, IRollerDataAccesLayer
    {
        public void Delete(int rolID)
        {
            throw new NotImplementedException();
        }

        public List<Roller> GetList()
        {
            throw new NotImplementedException();
        }
    }
}

