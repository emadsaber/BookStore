using BookStore.Core.Utilities.Commands.Implementatinos.Paging;
using BookStore.Models.Domain.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts.Repositories.Bases
{
    public interface IRepository<T> where T : Entity
    {
        public DbSet<T> DbSet { get; set; }

        void Add(T entity);
        void Update(T modifiedEntity);
        void SoftDelete(Guid id);
        Task SoftDeleteAsync(Guid id);
        Task<T> GetAsync<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes);
        Task<T> GetWithNoTrackingAsync<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes);
        T Get<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes);
        Task<PagedList<T>> GetPagedAsync(Expression<Func<T, bool>> filter, int pageNumber);
        T GetWithNoTracking<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes);
    }
}
