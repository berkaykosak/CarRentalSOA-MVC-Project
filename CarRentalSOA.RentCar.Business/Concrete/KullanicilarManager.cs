using CarRentalSOA.RentCar.Business.Abstract;
using CarRentalSOA.RentCar.DataAccess.Abstract;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Business.Concrete
{
    public class KullanicilarManager : IKullanicilarService
    {
        private IKullanicilarDataAccesLayer _kullanicilarDataAccesLayer;

        public KullanicilarManager(IKullanicilarDataAccesLayer kullanicilarDataAccesLayer)
        {
            _kullanicilarDataAccesLayer = kullanicilarDataAccesLayer;
        }

        public void Add(Kullanicilar kullanicilar)
        {
            _kullanicilarDataAccesLayer.Add(kullanicilar);
        }

        public void Delete(int kullanicilarID)
        {
            _kullanicilarDataAccesLayer.Delete(kullanicilarID);
        }

        public List<Kullanicilar> GetAll()
        {
            return _kullanicilarDataAccesLayer.GetList();
        }

        public void Update(Kullanicilar kullanicilar)
        {
            _kullanicilarDataAccesLayer.Update(kullanicilar);
        }
    }
}
