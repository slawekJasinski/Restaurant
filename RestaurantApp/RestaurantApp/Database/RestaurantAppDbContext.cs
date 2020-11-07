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

        DbSet<Dish> Dishes { get; set; }

        DbSet<Customer> Customers { get; set; }
    }
}
