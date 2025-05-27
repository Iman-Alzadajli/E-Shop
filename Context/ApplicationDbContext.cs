using E_Shop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Context
{
    public class ApplicationDbContext : DbContext
    {

        //flutent API 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-P6D70KOK; database = EsopDb ; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");


        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentInformation> PaymentInformation { get; set; }

        public DbSet<ShippingAddress> ShippingAddress { get; set; }

        public DbSet<Phone> Phone { get; set; }







    }

}
