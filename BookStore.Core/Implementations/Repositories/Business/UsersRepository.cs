using BookStore.Core.Contracts.Repositories.Bases;
using BookStore.Db.Context;
using BookStore.Models.Domain;

namespace BookStore.Core.Contracts.Repositories.Business
{
    public class UsersRepository : RepositoryBase<User>, IUsersRepository
    {
        public UsersRepository(BookStoreDbContext context) : base(context) { }
    }
}
