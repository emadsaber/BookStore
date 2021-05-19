using BookStore.Core.Contracts.Repositories.Business;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Registry
{
    public static class BookStoreCoreRegistry
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IBooksRepository, BooksRepository>();
            services.AddScoped<IAuthorsRepository, AuthorsRepository>();
            services.AddScoped<IReviewsRepository, ReviewsRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
        }
    }
}
