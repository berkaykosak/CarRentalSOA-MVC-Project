using CarRentalSOA.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace CarRentalSOA.RentCar.Entitites.Concrete
{
   public class Kullanicilar:IEntity
    {
        [Key]
        public int kullaniciID { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int yasi { get; set; }
        public int ehliyetYasi { get; set; }
        public int sifre { get; set; }
        public int RolID { get; set; }

    }
}
