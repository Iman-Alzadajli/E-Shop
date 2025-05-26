using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        [Required]
        public int Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [ForeignKey("CategoryId")]

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<OrderItem> OrderItems = new List<OrderItem>();
        public List<Review> Reviews = new List<Review>();
    }
}
