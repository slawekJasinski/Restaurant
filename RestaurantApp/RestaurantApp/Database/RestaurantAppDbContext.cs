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
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 1,
                    Name = "Ser",
                    Amount = 100
                });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 2,
                    Name = "Sos",
                    Amount = 100
                });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 3,
                    Name = "Szynka",
                    Amount = 100
                });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 4,
                    Name = "Pieczarki",
                    Amount = 100
                });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 5,
                    Name = "Salami Pepperoni",
                    Amount = 100
                });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 6,
                    Name = "Cebula",
                    Amount = 100
                });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 7,
                    Name = "Boczek",
                    Amount = 100
                });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 8,
                    Name = "Kurczak",
                    Amount = 100
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 1,
                    Name = "Capriciosa",
                    Price = 39.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos, ser, szynka, pieczarki",
                    Amount = 100
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Price = 36.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos, ser, salami pepperoni",
                    Amount = 100
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 3,
                    Name = "Funghi",
                    Price = 36.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos, ser, pieczarki",
                    Amount = 100
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 4,
                    Name = "Carbonara",
                    Price = 45.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos śmietanowy, ser, cebula, boczek, szpinak, pieczarki",
                    Amount = 100
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 5,
                    Name = "Broccoli",
                    Price = 47.50,
                    ImageUrl = "",
                    Availibility = true,
                    Description = "sos pomidorowy z ziołami, ser, cebula, borokuły, kukurydza, pieczarki, kurczaczek",
                    Amount = 100
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 6,
                    Name = "Margarita",
                    Price = 27.50,
                    ImageUrl = "",
                    Availibility = false,
                    Description = "sos pomidorowy z ziołami, ser",
                    Amount = 100
                });
        }
    }
}
