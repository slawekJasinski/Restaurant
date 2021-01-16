using RestaurantApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestaurantApp.Repository
{
    public interface IPriceItemRepository
    {
        List<DishSize> GetPriceItems();
        List<DishSize> GetById(int id);
        void Insert(DishSize dishSize);
        void Delete(int id);
        void Update(DishSize dishSize);
        void Save();
    }
}


/*
  using System.Collections.Generic;    
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
