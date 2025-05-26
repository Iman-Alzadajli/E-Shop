using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class Shipping_Address
    {
        [Key]

        public int Id { get; set; } 
        [Required]

        public int StreetAddress { get; set; }
        [Required]
        public int City { get; set; }
        [Required]
        public int State { get; set; }
        [Required]
        public int Country { get; set; }
        [Required]
        public int PostalCode { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
