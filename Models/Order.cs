using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderDate { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        [Required]

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
      
        public Customer Customer { get; set; }

        public List<OrderItem> OrderItem = new List<OrderItem>();
    }
}
