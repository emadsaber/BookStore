using BookStore.Core.Contracts.Repositories.Bases;
using BookStore.Db.Context;
using BookStore.Models.Domain;
using System.Linq;

namespace BookStore.Core.Contracts.Repositories.Business
{
    public class UsersRepository : RepositoryBase<User>, IUsersRepository
    {
        public UsersRepository(BookStoreDbContext context) : base(context) { }

        public User GetByAuthUserId(string authUserId)
        {
            return this.DbSet.FirstOrDefault(x => x.AuthUserId == authUserId);
        }
    }
}
