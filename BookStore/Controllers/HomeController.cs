﻿using BookStore.Core.Contracts.Services.Business;
using BookStore.Core.Utilities.Commands.Implementatinos.Paging;
using BookStore.Core.Utilities.Commands.Implementations;
using BookStore.Models.DTOs;
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
        [HttpGet("GetDashboardBooks")]
        public async Task<Response<PagedList<BookDto>>> GetDashboardBooks()
        {
            var books = await booksService.GetDashboardBooks(new Request<int>(10));
            
            return books;
        }
    }
}
