using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApp.Model;
using RestaurantApp.Database;

namespace RestaurantApp.Repository
{
    public interface IDishItemRepository
    {
        List<Dish> GetDishes();
        List<Dish> GetById(int id);
        void Insert(Dish dish);
        void Delete(int id);
        void Update(Dish dish);
        void Save();
    }
}
