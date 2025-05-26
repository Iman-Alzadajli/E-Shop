using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class Customer
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        [Required]
        public int Email { get; set; }
        [Required]
        public int Address { get; set; }
        [Required]

        public List<Order> Orders = new List<Order>();

    
        public List<Review> Reviews = new List<Review>();

        public List<Phone> Phones = new List<Phone>(); // conect information 



    }
}
