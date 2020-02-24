using Microsoft.EntityFrameworkCore;
using Model;
using Model.JoinTables;
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

            modelBuilder.Entity<CustomerRentalHistory>()
                .HasKey(crh => new {crh.CustomerId , crh.RentalHistoryId });
            modelBuilder.Entity<CustomerRentalHistory>()
                .HasOne(crh => crh.Customer)
                .WithMany(c => c.CustomerRentalHistory)
                .HasForeignKey(bc => bc.CustomerId);
            modelBuilder.Entity<CustomerRentalHistory>()
                .HasOne(bc => bc.RentalHistory)
                .WithMany(c => c.CustomerRentalHistory)
                .HasForeignKey(bc => bc.RentalHistoryId);

            modelBuilder.Entity<CarRentalHistory>()
                .HasKey(crh => new { crh.CarId, crh.RentalHistoryId });
            modelBuilder.Entity<CarRentalHistory>()
                .HasOne(crh => crh.Car)
                .WithMany(c => c.CarRentalHistory)
                .HasForeignKey(bc => bc.CarId);
            modelBuilder.Entity<CarRentalHistory>()
                .HasOne(bc => bc.RentalHistory)
                .WithMany(c => c.CarRentalHistory)
                .HasForeignKey(bc => bc.RentalHistoryId);
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RentalHistory> RentalHistorys { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
