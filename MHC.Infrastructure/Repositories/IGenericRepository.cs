﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHC.Infrastructure.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(Guid id);
        Task CreateAsync(T entity);
        Task Delete(Guid id);
        Task UpdateAsync(Guid id, T entity);
    }
}
