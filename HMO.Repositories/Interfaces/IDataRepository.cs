﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repositories.Interfaces
{
    public interface IDataRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(string id);
    }
}
