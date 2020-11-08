﻿using System;
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
                    Price = 39.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos, ser, szynka, pieczarki"
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Price = 36.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos, ser, salami pepperoni"
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 3,
                    Name = "Funghi",
                    Price = 36.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos, ser, pieczarki"
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 4,
                    Name = "Carbonara",
                    Price = 45.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos śmietanowy, ser, cebula, boczek, szpinak, pieczarki"
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 5,
                    Name = "Broccoli",
                    Price = 47.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos pomidorowy z ziołami, ser, cebula, borokuły, kukurydza, pieczarki, kurczaczek"
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 6,
                    Name = "Margarita",
                    Price = 27.50,
                    ImageUrl = "",
                    Availibility = false,
                    Description = "sos pomidorowy z ziołami, ser"
                });
        }
    }
}
