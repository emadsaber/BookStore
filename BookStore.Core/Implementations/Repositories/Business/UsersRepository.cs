using BookStore.Core.Contracts.Repositories.Bases;
using BookStore.Db.Context;
using BookStore.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts.Repositories.Business
{
    public class UsersRepository : RepositoryBase<User>, IUsersRepository
    {
        public UsersRepository(BookStoreDbContext context) : base(context) { }

        public async Task<User> GetByAuthUserIdAsync(string authUserId, bool isTracked = true)
        {
            var query = this.DbSet.AsQueryable();
            
            if (!isTracked)
            {
                query = query.AsNoTracking();
            }

            return await query.FirstOrDefaultAsync(x => x.AuthUserId == authUserId);
        }
    }
}
