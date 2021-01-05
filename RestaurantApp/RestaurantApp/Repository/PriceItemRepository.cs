using Microsoft.EntityFrameworkCore;
using RestaurantApp.Database;
using RestaurantApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Repository
{
    public class PriceItemRepository: IPriceItemRepository
    {
        private RestaurantAppDbContext context;

        public PriceItemRepository(RestaurantAppDbContext context)
        {
            this.context = context;
        }

        public List<DishSize> GetById(int id)
        {
            DateTime dToday = DateTime.Today;
            return context.Products.Where(a => ((a.DishId == id) && (DateTime.Compare(a.DateTo, dToday)>0) && (DateTime.Compare(a.DateFrom, dToday) < 0))).ToList<DishSize>();
        }

        public void Insert(DishSize dishSize)
        {
            context.Products.Add(dishSize);
        }

        public void Delete(int id)
        {
            DishSize dishSize = context.Products.Find(id);
            context.Products.Remove(dishSize);
        }

        public void Update(DishSize dishSize)
        {
            context.Entry(dishSize).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
