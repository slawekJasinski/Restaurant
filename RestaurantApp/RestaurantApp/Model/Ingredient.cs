using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestaurantApp.Model
{
        [Table("Ingredients")]
        public class Ingredient
        {
            [Key]
            [Column("id")]
            public int Id { get; set; }
            [Required]
            [MinLength(10)]
            [Column("name")]
            public string Name { get; set; }
            [Required]
            [Column("Amount")]
            public double Amount { get; set; }
        }
}
