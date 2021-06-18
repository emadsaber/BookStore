using BookStore.Core.Contracts.Repositories.Bases;
using BookStore.Models.Domain;

namespace BookStore.Core.Contracts.Repositories.Business
{
    public interface IUsersRepository : IRepository<User>
    {
        User GetByAuthUserId(string authUserId);
    }
}
