using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public int Comments { get; set; }

        [Required]
        public int ProductId { get; set; }
        [Required]
        public Product Product { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
