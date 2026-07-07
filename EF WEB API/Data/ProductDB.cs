using EF_WEB_API.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EF_WEB_API.Data
{
    public class ProductDB:DbContext
    {public ProductDB(DbContextOptions<ProductDB> options):base(options)
        {
            
            
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookPublisher> BookPublishers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductDB).Assembly);

            base.OnModelCreating(modelBuilder);

        }
        
    }
}
