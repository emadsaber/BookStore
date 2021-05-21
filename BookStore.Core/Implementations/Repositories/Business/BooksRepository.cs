using BookStore.Core.Contracts.Repositories.Bases;
using BookStore.Db.Context;
using BookStore.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Contracts.Repositories.Business
{
    public class BooksRepository : RepositoryBase<Book>, IBooksRepository
    {
        public BooksRepository(BookStoreDbContext context) : base(context) { }
    }
}
