using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    [Table("TypesSizes")]
    public class SizeType
    {
        [Key]
        [Column("SizeId")]
        public int SizeId { get; set; }
        [Required]
        [MinLength(10)]
        [Column("SizeName")]
        public string SizeName { get; set; }
        [Column("Unit")]
        public string Unit { get; set; }
    }
}
