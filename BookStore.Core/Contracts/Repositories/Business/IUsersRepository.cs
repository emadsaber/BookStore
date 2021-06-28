using BookStore.Core.Contracts.Repositories.Bases;
using BookStore.Models.Domain;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts.Repositories.Business
{
    public interface IUsersRepository : IRepository<User>
    {
        Task<User> GetByAuthUserIdAsync(string authUserId, bool isTracked = true);
    }
}
