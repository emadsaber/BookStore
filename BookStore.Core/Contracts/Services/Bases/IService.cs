using System.Threading.Tasks;

namespace BookStore.Core.Contracts.Services.Bases
{
    public interface IService
    {
        bool Save();
        Task<bool> SaveAsync();
    }
}
