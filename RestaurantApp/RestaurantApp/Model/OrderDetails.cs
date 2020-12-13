using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    [Table("DetailsOrder")]
    public class OrderDetails
    {
        [Key]
        [Column("DetailOrderId")]
        public int DetailOrderId { get; set; }
        [Required]
        [Column("OrderId")]
        public int OrderId { get; set; }
        [Column("ProductId")]
        public int ProductId { get; set; }
    }
}
