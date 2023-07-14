using EommerceEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EommerceEFCore.Data
{
    internal class EcommerceContext : DbContext
    {
        public DbSet<User> User { get; set; } = null!;
        public DbSet<Order> Order { get; set; } = null!;
        public DbSet<Product> Product { get; set; } = null!;
        public DbSet<OrderDetails> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=Ecommerce;Integrated Security=True;\r\n");
        }
    }
}
