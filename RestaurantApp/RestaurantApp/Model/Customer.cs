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
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Required]
        [Column("CustomerName")]
        public string CustomerName { get; set; }
        [Column("DeliveryAddress")]
        public string DeliveryAddress { get; set; }
        [Column("EmailAdress")]
        public string EmailAdress { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
