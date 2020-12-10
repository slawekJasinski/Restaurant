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
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [MinLength(10)]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("price")]
        public double Price { get; set; }
        [Column("imageUrl")]
        public string ImageUrl { get; set; }
        [MaxLength(255)]
        [Column("description")]
        public string Description { get; set; }
    }
}
