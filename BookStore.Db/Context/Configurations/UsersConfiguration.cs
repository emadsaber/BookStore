using BookStore.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Db.Context.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id)
                   .HasDefaultValueSql("(NEWID())");

            builder.Property(x => x.Title).HasMaxLength(10);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(300);
            builder.Property(x => x.CreatedOn).IsRequired().HasDefaultValueSql("(GETDATE())");

            builder.HasKey(x => x.Id);
        }
    }
}
