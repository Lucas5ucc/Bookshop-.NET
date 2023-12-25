using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopingCart.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(35)]
        public string? BookName { get; set; }
        public string Image { get; set; }

        public double Price { get; set; }


        [Required]
        public int GenderId { get; set; }
        public Genre Genre { get; set; }

        public List<OrderDetail> OrderDetails { get; set;}

        public List<CartDetail> CartDetails { get; set; }
    }
}
