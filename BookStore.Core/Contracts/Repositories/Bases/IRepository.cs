﻿using BookStore.Models.Domain.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        Task<T> GetAsync(Guid id);
        Task<T> GetWithNoTrackingAsync(Guid id);
        T Get(Guid id);
        T GetWithNoTracking(Guid id);
    }
}
