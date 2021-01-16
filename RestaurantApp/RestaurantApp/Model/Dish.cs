using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    [Table("Dishes")]
    public class Dish
    {
        [Key]
        [Column("DishId")]
        public int DishId { get; set; }
        [Required]
        [Column("TypeId")]
        public int TypeId { get; set; }
        [MinLength(10)]
        [Column("DishName")]
        public string DishName { get; set; }
        [Column("ImageUrl")]
        public string ImageUrl { get; set; }
        [MaxLength(255)]
        [Column("Description")]
        public string Description { get; set; }
        public List<DishSize> DishSizes { get; set; }
    }
}
