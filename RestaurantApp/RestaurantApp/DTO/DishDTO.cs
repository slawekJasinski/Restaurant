using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.DTO
{
    public class DishDTO
    {
        public int DishId { get; set; }
        public int DishTypeId { get; set; }
        public string DishName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
