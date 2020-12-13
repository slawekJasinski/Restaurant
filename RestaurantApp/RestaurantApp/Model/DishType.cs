using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class DishType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [MinLength(10)]
        [Column("name")]
        public string Name { get; set; }
    }
}
