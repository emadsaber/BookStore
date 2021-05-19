using BookStore.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Db.Context.Configurations
{
    public class ReviewsConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(x => x.Id)
                   .HasDefaultValueSql("(NEWID())");

            builder.Property(x => x.ReviewText).IsRequired().HasMaxLength(3000);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Rating).IsRequired().HasColumnType("decimal(2,1)");
            builder.Property(x => x.CreatedOn).IsRequired().HasDefaultValueSql("(GETDATE())");

            builder.HasKey(x => x.Id);
        }
    }
}
