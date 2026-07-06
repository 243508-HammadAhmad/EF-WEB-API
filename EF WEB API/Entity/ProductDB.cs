using Microsoft.EntityFrameworkCore;

namespace EF_WEB_API.Entity
{
    public class ProductDB:DbContext
    {public ProductDB(DbContextOptions<ProductDB> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
