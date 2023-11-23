using BookMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookMVC.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Set key for entity
            builder.HasKey(c => c.CategoryId);

            // Set requirements for 'Name' property
            builder.Property(c => c.CategoryName)
                   .IsRequired()
                   .HasMaxLength(100);

            // Configure any other properties or relationships
        }
    }
}
