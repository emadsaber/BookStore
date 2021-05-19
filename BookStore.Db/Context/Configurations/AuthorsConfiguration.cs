using BookStore.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Db.Context.Configurations
{
    public class AuthorsConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(x => x.Id)
                   .HasDefaultValueSql("(NEWID())");

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.JoinDate).IsRequired();
            builder.Property(x => x.Rating).IsRequired().HasColumnType("decimal(2,1)");
            builder.Property(x => x.CreatedOn).IsRequired().HasDefaultValueSql("(GETDATE())");

            builder.HasKey(x => x.Id);
        }
    }
}
