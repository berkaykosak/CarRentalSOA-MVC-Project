using CarRentalSOA.RentCar.Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSOA.RentCar.DataAccess.Concrete.EntityFramework
{
    public class CarRentalSOAContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-04QCQ6HF;Database=KiralikArac; Trusted_Connection=true");
        }
        public DbSet<AracBilgi>  AracBilgi { get; set; }
        public DbSet<KiralikBilgi> KiralikBilgi { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Roller> Roller { get; set; }
        public DbSet<Sirket> Sirket { get; set; }

    }
}
