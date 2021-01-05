using Microsoft.EntityFrameworkCore;
using RestaurantApp.Database;
using RestaurantApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Repository
{
    public class OrderRepository: IOrderRepository
    {
        private RestaurantAppDbContext context;

        public OrderRepository(RestaurantAppDbContext context)
        {
            this.context = context;
        }

        public List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return context.Orders.Find(id);
        }

        public void Insert(Order order)
        {
            context.Orders.Add(order);
        }

        public void Delete(int id)
        {
            Order order = context.Orders.Find(id);
            context.Orders.Remove(order);
        }

        public void Update(Order order)
        {
            context.Entry(order).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}

