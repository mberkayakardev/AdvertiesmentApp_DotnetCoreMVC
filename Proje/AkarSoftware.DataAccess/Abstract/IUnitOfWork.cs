﻿using AkarSoftware.Core.DataAccess.Abstract;
using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        public IEfGenericRepository<T> GetGenericRepostiory<T>() where T : class, IEntity, new();
        public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity, new() where TRepository : IEfGenericRepository<T>, new();
        Task SaveChangesAsync();
        void SaveChanges();

    }
}