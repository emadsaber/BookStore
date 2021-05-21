using BookStore.Core.Contracts.Services.Bases;
using BookStore.Core.Utilities.Commands.Implementatinos.Paging;
using BookStore.Core.Utilities.Commands.Implementations;
using BookStore.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts.Services.Business
{
    public interface IBooksService : IService
    {
        Task<Response<PagedList<BookDto>>> GetDashboardBooks(Request<int> request);
    }
}
