using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class PaymentInformation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PaymentMethod { get; set; }
        [Required]
        public int CardNumber { get; set; }
        [Required]
        public int ExpirationDate { get; set; }
        [Required]
        public int CVV { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
