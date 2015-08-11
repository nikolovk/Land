﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.Data.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();

        List<TEntity> PageAll(int skip, int take);
        Task<List<TEntity>> PageAllAsync(int skip, int take);

        TEntity FindById(object id);
        Task<TEntity> FindByIdAsync(object id);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        void SaveChanges();
    }
}
