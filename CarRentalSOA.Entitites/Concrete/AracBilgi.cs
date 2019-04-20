using CarRentalSOA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.Entitites.Concrete
{
    public class AracBilgi:IEntity
    {
        public int aracID { get; set; }
        public string aracMarkasi { get; set; }
        public string aracModeli { get; set; }
        public int gerekenEhliyetYasi { get; set; }
        public int minimumYas { get; set; }
        public int gunlukKmSinir { get; set; }
        public int anlikKm { get; set; }
        public bool airbag { get; set; }
        public int bagajHacmi { get; set; }
        public int koltukSayisi { get; set; }
        public int gunlukFiyat { get; set; }

    }
}
