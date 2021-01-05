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


/*
  using System.Collections.Generic;    
  using WebApiIntroductionApp.Models;
    public interface IBudgetItemRepository    
    {        
    List<BudgetItem> GetBudgetItems();
        BudgetItem GetById(int id);
        void Insert(BudgetItem budgetItem);
        void Delete(int id);
        void Update(BudgetItem budgetItem);
        void Save();    
        }
     */
