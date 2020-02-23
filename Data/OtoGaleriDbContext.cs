using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class OtoGaleriDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // todo: types must not be hard coded 
            //modelBuilder.Entity<User>()
            //        .ToTable("Users")
            //        .HasDiscriminator<string>("UserType")
            //        .HasValue<Customer>("Customer");
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RentalHistory> RentalHistorys { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
