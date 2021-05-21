using BookStore.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Db.Context.Configurations
{
    public class BooksConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Id)
                   .HasDefaultValueSql("(NEWID())");

            builder.Property(x => x.Title).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(3000);
            builder.Property(x => x.Rating).IsRequired().HasColumnType("decimal(2,1)");
            builder.Property(x => x.CreatedOn).IsRequired().HasDefaultValueSql("(GETDATE())");
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.Website).HasMaxLength(500);
            builder.Property(x => x.ISBN).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Publisher).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Subtitle).HasMaxLength(500);
            builder.Property(x => x.PublishedAt).HasColumnType("datetime2(7)");

            builder.HasKey(x => x.Id);

            builder.ToTable("Books");
        }
    }
}
