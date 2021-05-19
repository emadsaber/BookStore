using BookStore.Core.Contracts.Repositories.Bases;
using BookStore.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Contracts.Repositories.Business
{
    public interface IBooksRepository : IRepository<Book> { }
}
