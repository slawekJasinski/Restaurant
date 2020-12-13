using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Required]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column("StatusId")]
        public int StatusId { get; set; }
        [Column("Notes")]
        public string Notes { get; set; }
    }
}
