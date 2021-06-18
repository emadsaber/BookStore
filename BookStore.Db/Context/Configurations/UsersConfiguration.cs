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

            builder.Property(x => x.AuthUserId).IsRequired().HasMaxLength(70);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Nickname).HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PictureUrl).HasMaxLength(300);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CreatedOn).IsRequired().HasDefaultValueSql("(GETDATE())");
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);

            builder.HasKey(x => x.Id);
        }
    }
}
