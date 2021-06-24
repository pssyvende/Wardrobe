using Microsoft.EntityFrameworkCore;
using Wardrobe.Models;

namespace Wardrobe.Data
{
    public class WardrobeContext : DbContext
    {
        public WardrobeContext (DbContextOptions<WardrobeContext> options)
            : base(options)
        {
        }

        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemProp> ItemProps { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<ItemSize> ItemSizes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderTable> OrdersTable { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ItemCategory>().ToTable("ItemCategory");
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<ItemProp>().ToTable("ItemProp");
            modelBuilder.Entity<Photo>().ToTable("Photo");
            modelBuilder.Entity<ItemSize>().ToTable("ItemSize");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<OrderTable>().ToTable("OrderTable");
            modelBuilder.Entity<OrderDetails>().ToTable("OrderDetails");

        }
    }
}
