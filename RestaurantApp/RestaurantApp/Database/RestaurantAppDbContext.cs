using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using RestaurantApp.Model;

namespace RestaurantApp.Database
{
    public class RestaurantAppDbContext : DbContext
    {
        public RestaurantAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 1,
                    Name = "Capriciosa",
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos, ser, szynka, pieczarki",
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 2,
                    Name = "Pepperoni",
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos, ser, salami pepperoni",
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 3,
                    Name = "Funghi",
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos, ser, pieczarki",
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 4,
                    Name = "Carbonara",
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos śmietanowy, ser, cebula, boczek, szpinak, pieczarki",
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 5,
                    Name = "Broccoli",
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos pomidorowy z ziołami, ser, cebula, borokuły, kukurydza, pieczarki, kurczaczek",
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 6,
                    Name = "Margarita",
                    ImageUrl = "",
                    Availibility = false,
                    Description = "sos pomidorowy z ziołami, ser",
                });
        }
    }
}
