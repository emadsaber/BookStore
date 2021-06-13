using AutoMapper;
using BookStore.Core.Contracts.Repositories.Business;
using BookStore.Core.Contracts.Services.Business;
using BookStore.Core.Implementations.Services.Business.Bases;
using BookStore.Core.Utilities.Commands.Implementatinos.Paging;
using BookStore.Core.Utilities.Commands.Implementations;
using BookStore.Db.Context;
using BookStore.Models.Domain;
using BookStore.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Core.Implementations.Services.Business
{
    public class BooksService : ServicesBase, IBooksService
    {
        #region fields
        private readonly IBooksRepository booksRepo;
        #endregion

        #region ctor

        public BooksService(BookStoreDbContext dbContext, IBooksRepository booksRepo, IMapper mapper) : base(dbContext, mapper)
        {
            this.booksRepo = booksRepo;
        }

        #endregion

        #region IBooksService

        public async Task<ApiResponse<PagedList<BookDto>>> GetDashboardBooks(ApiRequest request)
        {
            if (!request.Validate())
            {
                return ApiResponse.InvalidRequest<PagedList<BookDto>>();
            }

            var booksPaged = await booksRepo.GetPagedAsync<bool>(x => !x.IsDeleted, 1); //todo : apply page number
            var mappedBooks = Mapper.Map<List<BookDto>>(booksPaged.PagedData);
            var mappedBooksPaged = PagedList<BookDto>.CopyFrom(booksPaged, mappedBooks);

            return ApiResponse.SuccessResponse(mappedBooksPaged);
        }

        public async Task<ApiResponse<BookDto>> GetBookDetails(ApiRequest<Guid> request)
        {
            if (!request.Validate())
            {
                return ApiResponse.InvalidRequest<BookDto>();
            }

            var book = await booksRepo.GetAsync(request.Data, 
                nameof(Book.Authors), 
                nameof(Book.Reviews), 
                $"{nameof(Book.Reviews)}.{nameof(Review.User)}");
            
            var bookDto = Mapper.Map<BookDto>(book);

            return ApiResponse.SuccessResponse(bookDto);
        }
        
        #endregion
    }
}
