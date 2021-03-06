﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    [Table("TypesDishes")]
    public class DishType
    {
        [Key]
        [Column("TypeId")]
        public int TypeId { get; set; }
        [Required]
        [MinLength(10)]
        [Column("TypeName")]
        public string TypeName { get; set; }
    }
}
