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
        public DbSet<Product> products { get; set; }

    }

}
