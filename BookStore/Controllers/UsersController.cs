using BookStore.Core.Contracts.Services.Business;
using BookStore.Core.Utilities.Commands.Implementations;
using BookStore.Models.DTOs;
using BookStore.Models.DTOs.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        [HttpPost("CreateOrUpdate")]
        public async Task<ApiResponse<bool>> CreateOrUpdate(ApiRequest<AuthUserDto> request)
        {
            if (!request.Validate())
            {
                return ApiResponse.FailureResponse<bool>("Invalid Object body");
            }

            var response = await usersService.CreateOrUpdate(request.Data);

            return response;
        }

        [HttpPost("GetUserByAuthUserId")]
        public async Task<ApiResponse<UserDto>> GetUserByAuthUserId(ApiRequest<string> request)
        {
            if (!request.Validate())
            {
                return ApiResponse.FailureResponse<UserDto>("Invalid Object body");
            }

            var response = await usersService.GetUserByAuthUserId(request.Data);
            
            return response;
        }
    }
}
