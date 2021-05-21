using BookStore.Core.Contracts.Repositories.Bases;
using BookStore.Db.Context;
using BookStore.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Contracts.Repositories.Business
{
    public class AuthorsRepository : RepositoryBase<Author>, IAuthorsRepository
    {
        public AuthorsRepository(BookStoreDbContext context) : base(context) { }
    }
}
