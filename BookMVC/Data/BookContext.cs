using BookMVC.Configurations;
using BookMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMVC.Data
{
    public class BookContext : DbContext
    {
        // Optionally, you can add a constructor to pass the options to the base DbContext
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartsDetail { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CartDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
        }

    }
}