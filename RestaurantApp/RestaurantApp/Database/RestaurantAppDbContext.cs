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
        public DbSet<DishType> TypesDishes { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<SizeType> TypesSizes { get; set; }
        public DbSet<DishSize> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> DetailsOrder { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishType>().HasData(
                new DishType
                {
                    TypeId = 1,
                    TypeName = "Pizza"
                });
            modelBuilder.Entity<DishType>().HasData(
                new DishType
                {
                    TypeId = 2,
                    TypeName = "Dania obiadowe"
                });
            modelBuilder.Entity<DishType>().HasData(
                new DishType
                {
                    TypeId = 3,
                    TypeName = "Fast food"
                });
            modelBuilder.Entity<DishType>().HasData(
                new DishType
                {
                    TypeId = 4,
                    TypeName = "Zupy"
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 1,
                    TypeId = 1,
                    DishName = "Capriciosa",
                    ImageUrl = "https://foodish-api.herokuapp.com/images/pizza/pizza70.jpg",
                    Description = "sos, ser, szynka, pieczarki"
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 2,
                    TypeId = 1,
                    DishName = "Margarita",
                    ImageUrl = "https://foodish-api.herokuapp.com/images/pizza/pizza60.jpg",
                    Description = "sos, ser"
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 3,
                    TypeId = 2,
                    DishName = "Naleśniki",
                    ImageUrl = "https://foodish-api.herokuapp.com/images/dosa/dosa63.jpg",
                    Description = "Jabłka, cynamon, syrop klonowy"
                });
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 4,
                    TypeId = 3,
                    DishName = "Burger",
                    ImageUrl = "https://foodish-api.herokuapp.com/images/burger/burger8.jpg",
                    Description = "Beef, Lettuce, Tomato, Mayo"
                });
            modelBuilder.Entity<SizeType>().HasData(
                new SizeType
                {
                    SizeId = 1,
                    SizeName = "30",
                    Unit = "cm"
                });
            modelBuilder.Entity<SizeType>().HasData(
                new SizeType
                {
                    SizeId = 2,
                    SizeName = "40",
                    Unit = "cm"
                });
            modelBuilder.Entity<SizeType>().HasData(
                new SizeType
                {
                    SizeId = 3,
                    SizeName = "50",
                    Unit = "cm"
                });
            modelBuilder.Entity<DishSize>().HasData(
                new DishSize
                {
                    ProductId = 1,
                    DishId = 1,
                    SizeId = 1,
                    Price = 20.99,
                    DateFrom = "2020.12.13",
                    DateTo = "2021.12.13"
                });
            modelBuilder.Entity<DishSize>().HasData(
                new DishSize
                {
                    ProductId = 2,
                    DishId = 1,
                    SizeId = 2,
                    Price = 30.99,
                    DateFrom = "2020.12.13",
                    DateTo = "2021.12.13"
                });
            modelBuilder.Entity<DishSize>().HasData(
                new DishSize
                {
                    ProductId = 3,
                    DishId = 1,
                    SizeId = 3,
                    Price = 40.99,
                    DateFrom = "2020.12.13",
                    DateTo = "2021.12.13"
                });
            modelBuilder.Entity<DishSize>().HasData(
                new DishSize
                {
                    ProductId = 4,
                    DishId = 2,
                    SizeId = 1,
                    Price = 19.99,
                    DateFrom = "2020.12.13",
                    DateTo = "2021.12.13"
                });
            modelBuilder.Entity<DishSize>().HasData(
                new DishSize
                {
                    ProductId = 5,
                    DishId = 2,
                    SizeId = 2,
                    Price = 29.99,
                    DateFrom = "2020.12.13",
                    DateTo = "2021.12.13"
                });
            modelBuilder.Entity<DishSize>().HasData(
                new DishSize
                {
                    ProductId = 6,
                    DishId = 2,
                    SizeId = 3,
                    Price = 39.99,
                    DateFrom = "2020.12.13",
                    DateTo = "2021.12.13"
                });
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Kamil Cichocki",
                    DeliveryAddress = "ul. Warszawska 10/14, Poznań",
                    EmailAdress = "kamil.cichocki@domena.pl",
                    PhoneNumber = "999-888-777"
                });
            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    StatusId = 1,
                    StatusName = "Przyjęto do realizacji"
                });
            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    StatusId = 2,
                    StatusName = "W przygotowaniu"
                });
            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    StatusId = 3,
                    StatusName = "W trakcie dostawy"
                });
            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    StatusId = 4,
                    StatusName = "Dostarczone"
                });
            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    StatusId = 5,
                    StatusName = "Anulowane"
                });
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    CustomerId = 1,
                    StatusId = 1,
                    Notes = "Nie działa domofon proszę dzwonić"
                });
            modelBuilder.Entity<OrderDetails>().HasData(
                new OrderDetails
                {
                    DetailOrderId = 1,
                    OrderId = 1,
                    ProductId = 1
                });
            modelBuilder.Entity<OrderDetails>().HasData(
                new OrderDetails
                {
                    DetailOrderId = 2,
                    OrderId = 1,
                    ProductId = 3
                });
            modelBuilder.Entity<OrderDetails>().HasData(
                new OrderDetails
                {
                    DetailOrderId = 3,
                    OrderId = 1,
                    ProductId = 6
                });
        }
    }
}
