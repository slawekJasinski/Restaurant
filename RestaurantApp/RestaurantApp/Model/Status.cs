using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    [Table("Statuses")]
    public class Status
    {
        [Key]
        [Column("StatusId")]
        public int StatusId { get; set; }
        [Required]
        [Column("StatusName")]
        public string StatusName { get; set; }
    }
}
