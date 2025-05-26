using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
