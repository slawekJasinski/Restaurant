using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RestaurantApp.Model
{
    public class Order
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string name { get; set; }
        [Column("status")]
        public Status status { get; set; }
    }
}
