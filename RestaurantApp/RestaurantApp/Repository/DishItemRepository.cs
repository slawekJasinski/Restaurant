using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApp.Model;
using RestaurantApp.Database;
using RestaurantApp.Repository;

namespace RestaurantApp.Repository
{
    public class DishItemRepository : IDishItemRepository
    {
        private RestaurantAppDbContext context;

        public DishItemRepository(RestaurantAppDbContext context)
        {
            this.context = context;
        }

        public List<Dish> GetById(int id)
        {
            return context.Dishes.Where(a => (a.TypeId == id)).ToList<Dish>();
        }

        public void Insert(Dish dish)
        {
            context.Dishes.Add(dish);
        }
       
        public void Delete(int id)
        {
            Dish dish = context.Dishes.Find(id);
            context.Dishes.Remove(dish);
        }

        public void Update(Dish dish)
        {
            context.Entry(dish).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public List<Dish> GetDishes()
        {
            return context.Dishes.ToList<Dish>();
        }
    }
}
