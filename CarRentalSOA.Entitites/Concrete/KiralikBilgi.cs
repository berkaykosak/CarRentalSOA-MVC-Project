using CarRentalSOA.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRentalSOA.RentCar.Entitites.Concrete
{
    public class KiralikBilgi:IEntity
    {
        [Key]
        public int kiralıkID  { get; set; }
        public DateTime baslangicTarihi { get; set; }
        public DateTime bitisTarihi { get; set; }
        public int verilenKm { get; set; }
        public int alinanKm { get; set; }
        public int alinanUcret { get; set; }
        public int kullaniciID { get; set; }
        public int rezervasyonID { get; set; }
        public int aracID { get; set; }




    }
}
