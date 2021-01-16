using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.DTO
{
    public class PriceItemDTO
    {
        public int ProductId { get; set; }
        public int DishId { get; set; }
        public int SizeId { get; set; }
        public double Price { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }
}
