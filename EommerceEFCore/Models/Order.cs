using System.ComponentModel.DataAnnotations;

namespace EommerceEFCore.Models
{
    public class Order
    {
        private User user = null!;

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }


        public User User { get; set; } = null!;

        public ICollection<OrderDetails> OrderDetails {get; set;} = null!;
        

    }
}