using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EommerceEFCore.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public ICollection<Order> Orders { get; set; } = null!;
    }
}
