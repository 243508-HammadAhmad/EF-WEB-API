using EF_WEB_API.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EF_WEB_API.Data
{
    public class ProductDB:DbContext
    {public ProductDB(DbContextOptions<ProductDB> options):base(options)
        {
            
            
        }
        public DbSet<Author> Products { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookPublisher> BookPublishers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.AuthorId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);


                entity.HasOne(a => a.publisher)
                      .WithOne(p => p.author)
                      .HasForeignKey<Publisher>(p => p.AuthorId)
                      .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Book>(entity =>
            {entity.HasKey(a=> a.BookId);
                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(a => a.author)
                      .WithMany(b => b.Books)
                      .HasForeignKey(a => a.AuthorId)
                      .OnDelete(DeleteBehavior.NoAction);


            });
            modelBuilder.Entity<Publisher>(entity =>
            {entity.HasKey(a=>a.PublisherId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

            });
            modelBuilder.Entity<BookPublisher>(entity => {
            entity.HasKey(bp => new { bp.BookId, bp.PublisherId });

                entity.HasOne(a => a.book)
                .WithMany(b => b.BookPublishers)
                .HasForeignKey(bp => bp.BookId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(a => a.publisher)
                .WithMany(b => b.BookPublishers)
                .HasForeignKey(bp=>bp.PublisherId)
                .OnDelete(DeleteBehavior.NoAction);



            });

        }
        
    }
}
