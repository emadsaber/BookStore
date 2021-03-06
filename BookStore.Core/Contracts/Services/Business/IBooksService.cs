using BookStore.Core.Contracts.Services.Bases;
using BookStore.Core.Utilities.Commands.Implementatinos.Paging;
using BookStore.Core.Utilities.Commands.Implementations;
using BookStore.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts.Services.Business
{
    public interface IBooksService : IService
    {
        Task<ApiResponse<PagedList<BookDto>>> GetDashboardBooks(ApiRequest request);
        Task<ApiResponse<BookDto>> GetBookDetails(ApiRequest<Guid> request);
    }
}
