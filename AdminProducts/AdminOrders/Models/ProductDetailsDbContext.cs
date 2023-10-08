using Microsoft.EntityFrameworkCore;

namespace AdminOrders.Models
{
    public class ProductDetailsDbContext : DbContext
    {
        public ProductDetailsDbContext(DbContextOptions<ProductDetailsDbContext> options) : base(options)
        {
        }

        public DbSet<ProductDetails> ProductDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SCARLETSPELLCAS;database=AdminProduct;trusted_connection=true; TrustServerCertificate=true;");
        }
    }
}

