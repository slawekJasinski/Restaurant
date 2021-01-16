using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApp.Model;
using RestaurantApp.Database;


namespace RestaurantApp.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetById(int id);
        void Insert(Order order);
        void Delete(int id);
        void Update(Order order);
        void Save();
    }
}

