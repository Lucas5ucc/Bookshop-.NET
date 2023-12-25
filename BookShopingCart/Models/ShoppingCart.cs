using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopingCart.Models
{
    [Table("ShoppingCart")]
    public class ShopingCart
    {
        public int Id { get; set; }
        [Required]
        public string UserID { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
