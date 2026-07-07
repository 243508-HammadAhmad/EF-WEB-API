using EF_WEB_API.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EF_WEB_API.Configurations
{
    public class BookPublisherConfiguration:IEntityTypeConfiguration<BookPublisher>
    {public void Configure(EntityTypeBuilder<BookPublisher> builder)
        {
            builder.HasKey(bp => new { bp.BookId, bp.PublisherId });
            
            builder.HasOne(bp => bp.book)
                .WithMany(b => b.BookPublishers)
                .HasForeignKey(bp => bp.BookId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(bp=>bp.publisher)
                .WithMany(p => p.BookPublishers)
                .HasForeignKey(bp => bp.PublisherId)
                .OnDelete(DeleteBehavior.NoAction); 

        }
    }
}
