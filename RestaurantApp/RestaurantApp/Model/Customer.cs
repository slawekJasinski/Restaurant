using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        public List<Dish> Dishes { get; set; }
    }
}
