using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    [Table("Products")]
    public class DishSize
    {
        [Key]
        [Column("ProductId")]
        public int ProductId { get; set; }
        [Required]
        [Column("DishId")]
        public int DishId { get; set; }
        [MinLength(10)]
        [Column("SizeId")]
        public int SizeId { get; set; }
        [Column("Price")]
        public double Price { get; set; }
        [Column("DateFrom")]
        public DateTime DateFrom { get; set; }
        [Column("DateTo")]
        public DateTime DateTo { get; set; }
    }
}
