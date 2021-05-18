using BookStore.Db.Context.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Db.Context
{
    public class BookStoreDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BooksConfiguration());
        }
    }
}
