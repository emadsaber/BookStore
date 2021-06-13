using BookStore.Core.Utilities.Commands.Implementatinos.Paging;
using BookStore.Models.Domain.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts.Repositories.Bases
{
    public class RepositoryBase<T> : IRepository<T> where T : Entity
    {
        public RepositoryBase(DbContext context)
        {
            this.DbSet = context.Set<T>();
        }
        public DbSet<T> DbSet { get; set; }

        public void Add(T entity)
        {
            this.DbSet.Add(entity);
        }

        public T Get<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes)
        {
            var query = this.DbSet.AsQueryable();
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query.FirstOrDefault(x => x.Id == id);
        }

        public async Task<PagedList<T>> GetPagedAsync<TKey>(Expression<Func<T, bool>> filter, int pageNumber, Expression<Func<T, TKey>> orderBy = default, bool? isDescending = true)
        {
            var query = this.DbSet.AsNoTracking().Where(filter);

            var totalCount = query.Count();
            var pageSize = 10;
            var pagesCount = totalCount % pageSize == 0 ? totalCount / pageSize
                                                        : (totalCount / pageSize) + 1;
            if (orderBy != default)
            {
                if (isDescending == true)
                {
                    query = query.OrderByDescending(orderBy);
                }
                else
                {
                    query = query.OrderBy(orderBy);
                }
            }
            else
            {
                query = query.OrderByDescending(x => x.CreatedOn);
            }
            
            var data = await query.Skip((pageNumber - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToListAsync();

            return PagedList<T>.GetPaged(data, pageNumber, pageSize, pagesCount, totalCount);
        }
        public async Task<PagedList<T>> GetPagedAsync<TProperty, TKey>(Expression<Func<T, bool>> filter, int pageNumber, Expression<Func<T, TKey>> orderBy = default, bool? isDescending = true, params Expression<Func<T, TProperty>>[] includes)
        {
            var query = this.DbSet.AsNoTracking().Where(filter);
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            var totalCount = query.Count();
            var pageSize = 10;
            var pagesCount = totalCount % pageSize == 0 ? totalCount / pageSize
                                                        : (totalCount / pageSize) + 1;
            if (orderBy != default)
            {
                if (isDescending == true)
                {
                    query = query.OrderByDescending(orderBy);
                }
                else
                {
                    query = query.OrderBy(orderBy);
                }
            }
            else
            {
                query = query.OrderByDescending(x => x.CreatedOn);
            }


            var data = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            return PagedList<T>.GetPaged(data, pageNumber, pageSize, pagesCount, totalCount);
        }
        public async Task<T> GetAsync<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes)
        {
            var query = this.DbSet.AsQueryable();
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<T> GetAsync(Guid id, params string[] includes)
        {
            var query = this.DbSet.AsQueryable();
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }
        public T GetWithNoTracking<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes)
        {
            var query = this.DbSet.AsNoTracking();
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query.FirstOrDefault(x => x.Id == id);
        }
        public async Task<List<T>> GetAllWithNoTrackingAsync<TProperty>(Expression<Func<T, bool>> filter, params Expression<Func<T, TProperty>>[] includes)
        {
            var query = this.DbSet.AsNoTracking();
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return await query.Where(filter).ToListAsync();
        }
        public async Task<T> GetWithNoTrackingAsync<TProperty>(Guid id, params Expression<Func<T, TProperty>>[] includes)
        {
            var query = this.DbSet.AsNoTracking();
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void SoftDelete(Guid id)
        {
            var entity = this.Get<object>(id);
            if (entity != default)
            {
                entity.IsDeleted = true;
            }
        }

        public async Task SoftDeleteAsync(Guid id)
        {
            var entity = await this.GetAsync<object>(id);
            if (entity != default)
            {
                entity.IsDeleted = true;
            }
        }
        public async Task HardDeleteAsync(Guid id)
        {
            var entity = await this.GetAsync<object>(id);
            if (entity != default)
            {
                DbSet.Remove(entity);
            }
        }
        public void Update(T modifiedEntity)
        {
            this.DbSet.Update(modifiedEntity);
        }

        public async Task<T> GetWithNoTrackingAsync(Guid id, params string[] includes)
        {
            var query = this.DbSet.AsNoTracking();
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> filter)
        {
            return this.DbSet.AsNoTracking().Where(filter).CountAsync();
        }

        public T Get(Guid id, params string[] includes)
        {
            var query = this.DbSet.AsQueryable();
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query.FirstOrDefault(x => x.Id == id);
        }

        public T GetWithNoTracking(Guid id, params string[] includes)
        {
            var query = this.DbSet.AsNoTracking();
            if (includes != null && includes.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query.FirstOrDefault(x => x.Id == id);
        }
    }
}
