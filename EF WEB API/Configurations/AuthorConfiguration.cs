using EF_WEB_API.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EF_WEB_API.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);
            builder.Property(a =>a.Name).IsRequired().HasMaxLength(50);


            builder.HasOne(a=>a.publisher)
              .WithOne(b=>b.author)
              .HasForeignKey<Publisher>(a=>a.AuthorId)
            .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
