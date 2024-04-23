using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int OrderedQuantity { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
