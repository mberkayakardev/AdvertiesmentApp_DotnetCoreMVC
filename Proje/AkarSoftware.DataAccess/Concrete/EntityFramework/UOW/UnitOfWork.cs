using AkarSoftware.Core.DataAccess.Abstract;
using AkarSoftware.Core.Entities.Abstract;
using AkarSoftware.DataAccess.Abstract;
using AkarSoftware.DataAccess.Concrete.EntityFramework.DbContexts;
using System.ComponentModel;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContexts _dbContexts;
        public UnitOfWork(MyDbContexts myDbContexts)
        {
            _dbContexts = myDbContexts;
        }

        #region SaveChanges
        public void SaveChanges()
        {
            _dbContexts.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _dbContexts.SaveChangesAsync();
        }
        #endregion

        IEfGenericRepository<T> IUnitOfWork.GetGenericRepostiory<T>()
        {
            return new Core.DataAccess.Concrete.EntityFramework.EfGenericRepository<T>(_dbContexts);
        }

        public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity , new() where TRepository : IEfGenericRepository<T>, new()
        {
            var repository = (TRepository)Activator.CreateInstance(typeof(TRepository), _dbContexts);
            return repository;
        }
    }
}
