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
        Task HardDeleteAsync(Guid id);
        Task<T> GetAsync<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes);
        Task<List<T>> GetAllWithNoTrackingAsync<TProperty>(Expression<Func<T, bool>> filter, params Expression<Func<T, TProperty>>[] includes);
        Task<T> GetAsync(Guid id, params string[] includes);
        Task<T> GetWithNoTrackingAsync<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes);
        Task<T> GetWithNoTrackingAsync(Guid id, params string[] includes);
        Task<int> CountAsync(Expression<Func<T, bool>> filter);
        T Get<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes);
        T Get(Guid id, params string[] includes);
        Task<PagedList<T>> GetPagedAsync<TKey>(Expression<Func<T, bool>> filter, int pageNumber, Expression<Func<T, TKey>> orderBy = default, bool? isDescending = true);
        Task<PagedList<T>> GetPagedAsync<TProperty, TKey>(Expression<Func<T, bool>> filter, int pageNumber, Expression<Func<T, TKey>> orderBy = default, bool? isDescending = true, params Expression<Func<T, TProperty>>[] includes);
        T GetWithNoTracking<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes);
        T GetWithNoTracking(Guid id, params string[] includes);
    }
}
