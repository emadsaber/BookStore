using BookStore.Core.Contracts.Services.Business;
using BookStore.Core.Utilities.Commands.Implementatinos.Paging;
using BookStore.Core.Utilities.Commands.Implementations;
using BookStore.Models.DTOs;
using BookStore.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IBooksService booksService;

        public HomeController(IBooksService booksService)
        {
            this.booksService = booksService;
        }
        
        [HttpPost("GetDashboardBooks")]
        public async Task<ApiResponse<PagedList<BookDto>>> GetDashboardBooks(ApiRequest request)
        {
            var books = await booksService.GetDashboardBooks(request);
            
            return books;
        }

        [HttpPost("GetBookDetails")]
        public async Task<ApiResponse<BookDto>> GetBookDetails(ApiRequest<Guid> request)
        {
            var book = await booksService.GetBookDetails(request);

            return book;
        }

        [HttpPost("EditBookDetails")]
        [Authorize(SecurityScopes.EDIT_BOOK_DETAILS)]
        public async Task<ApiResponse<BookDto>> EditBookDetails(ApiRequest<Guid> request)
        {
            var book = await booksService.GetBookDetails(request);

            return book;
        }
    }
}
