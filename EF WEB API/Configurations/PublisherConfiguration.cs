using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF_WEB_API.Entity;
namespace EF_WEB_API.Configurations
{
    public class PublisherConfiguration:IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(p => p.PublisherId);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);   

           
        }
    }
}   
