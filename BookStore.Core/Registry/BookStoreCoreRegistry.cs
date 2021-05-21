using BookStore.Core.Contracts.Repositories.Business;
using BookStore.Core.Contracts.Services.Business;
using BookStore.Core.Implementations.Services.Business;
using BookStore.Core.Mappings;
using BookStore.Db.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Registry
{
    public static class BookStoreCoreRegistry
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            RegisterDbContext(services, configuration);
            RegisterRepositories(services);
            RegisterMappings(services);
            RegisterBusinessServices(services);
        }

        #region helpers

        private static void RegisterDbContext(IServiceCollection services, IConfiguration config)
        {
            var connStr = config.GetConnectionString("BookStoreDB");
            services.AddDbContext<BookStoreDbContext>(options => options.UseSqlServer(connStr));
        }
        
        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IBooksRepository, BooksRepository>();
            services.AddScoped<IAuthorsRepository, AuthorsRepository>();
            services.AddScoped<IReviewsRepository, ReviewsRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
        }

        private static void RegisterBusinessServices(IServiceCollection services)
        {
            services.AddScoped<IBooksService, BooksService>();
        }

        private static void RegisterMappings(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BasicMappingProfiles));
        }

        #endregion
    }
}
