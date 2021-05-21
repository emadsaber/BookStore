using AutoMapper;
using BookStore.Core.Contracts.Services.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Implementations.Services.Business.Bases
{
    public class ServicesBase : IService
    {
        public ServicesBase(DbContext context, IMapper mapper)
        {
            this.context = context;
            Mapper = mapper;
        }
        #region props

        private DbContext context;

        public IMapper Mapper { get; }

        #endregion

        #region IService

        public bool Save()
        {
            return this.context.SaveChanges() > 0;
        }

        public async Task<bool> SaveAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        #endregion
    }
}
