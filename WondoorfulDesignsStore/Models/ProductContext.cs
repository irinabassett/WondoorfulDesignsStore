using System.Data.Entity;

namespace WondoorfulDesignsStore.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WondoorfulDesignsStore")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}

