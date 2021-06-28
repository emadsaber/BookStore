using BookStore.Core.Contracts.Services.Bases;
using BookStore.Core.Utilities.Commands.Implementations;
using BookStore.Models.DTOs;
using BookStore.Models.DTOs.Users;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts.Services.Business
{
    public interface IUsersService : IService
    {
        Task<ApiResponse<bool>> CreateOrUpdate(AuthUserDto request);
        Task<ApiResponse<UserDto>> GetUserByAuthUserId(string data);
    }
}
