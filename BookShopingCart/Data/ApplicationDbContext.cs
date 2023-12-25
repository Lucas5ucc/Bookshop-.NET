using BookShopingCart.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShopingCart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genre { get; set; }

        public DbSet<ShopingCart> ShopingCarts { get; set; }

        public DbSet<CartDetail> CartDetails { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }
        
    }
}
