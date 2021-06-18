using AutoMapper;
using BookStore.Core.Contracts.Repositories.Business;
using BookStore.Core.Contracts.Services.Business;
using BookStore.Core.Implementations.Services.Business.Bases;
using BookStore.Core.Utilities.Commands.Implementations;
using BookStore.Core.Validations;
using BookStore.Db.Context;
using BookStore.Models.Domain;
using BookStore.Models.DTOs.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BookStore.Core.Implementations.Services.Business
{
    public class UsersService : ServicesBase, IUsersService
    {
        private readonly IUsersRepository usersRepository;
        #region ctor

        public UsersService(BookStoreDbContext context, IMapper mapper, IUsersRepository usersRepository) : base(context, mapper)
        {
            this.usersRepository = usersRepository;
        }

        #endregion

        #region IUsersService
        public async Task<ApiResponse<bool>> CreateOrUpdate(AuthUserDto data)
        {
            var validateResult = new AuthUserValidator().Validate(data);
            if (!validateResult.IsValid)
            {
                return ApiResponse.FailureResponse<bool>(validateResult);
            }

            var isExist = await usersRepository.CountAsync(x => x.AuthUserId == data.AuthUserId) > 0;
            
            if (isExist)
            {
                //update user details
                var existing = usersRepository.GetByAuthUserId(authUserId: data.AuthUserId);
                
                existing = Mapper.Map(data, existing);

                usersRepository.Update(existing);
            }
            else
            {
                var user = Mapper.Map<User>(data);
                if (user == null)
                {
                    return ApiResponse.FailureResponse<bool>("CreateOrUpdate : Failed map before update");
                }
                //create user
                usersRepository.Add(user);
            }

            var res = await SaveAsync();

            return res ? ApiResponse.SuccessResponse(res) : ApiResponse.FailureResponse(res);
        } 

        #endregion
    }
}
