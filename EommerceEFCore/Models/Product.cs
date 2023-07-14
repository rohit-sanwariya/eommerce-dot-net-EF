using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EommerceEFCore.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public  string? Description { get; set; }
        public int Price { get; set; }
        public required string ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
