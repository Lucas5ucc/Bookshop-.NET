using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopingCart.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int Qantity { get; set; }
        [Required]
        public int UnityPrice { get; set; }

        public Order Order { get; set; }

        public Book Book { get; set; } 

    }
}
