using CarRentalSOA.RentCar.Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.DataAccess.Concrete.EntityFramework
{
    public class CarRentalSOAContex:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-04QCQ6HF;Databases=KiralikAraç; Trusted_Connection=true");
        }
        public DbSet<AracBilgi>  AracBilgis { get; set; }
        public DbSet<KiralikBilgi> KiralikBilgis { get; set; }
        public DbSet<Kullanicilar> Kullanicilars { get; set; }
        public DbSet<Roller> Rollers { get; set; }
        public DbSet<Sirket> Sirkets { get; set; }

    }
}
