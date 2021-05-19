using BookStore.Models.Domain.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts.Repositories.Bases
{
    public class RepositoryBase<T> : IRepository<T> where T : Entity
    {
        public DbSet<T> DbSet { get; set; }

        public void Add(T entity)
        {
            this.DbSet.Add(entity);
        }

        public T Get(Guid id)
        {
            return this.DbSet.Find(id);
        }

        public async Task<T> GetAsync(Guid id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public T GetWithNoTracking(Guid id)
        {
            return this.DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public async Task<T> GetWithNoTrackingAsync(Guid id)
        {
            return await this.DbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public void SoftDelete(Guid id)
        {
            var entity = this.Get(id);
            if(entity != default)
            {
                entity.IsDeleted = true;
            }
        }

        public async Task SoftDeleteAsync(Guid id)
        {
            var entity = await this.GetAsync(id);
            if (entity != default)
            {
                entity.IsDeleted = true;
            }
        }

        public void Update(T modifiedEntity)
        {
            this.DbSet.Update(modifiedEntity);
        }
    }
}
