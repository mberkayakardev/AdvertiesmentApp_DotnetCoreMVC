using AkarSoftware.Core.DataAccess.Abstract;
using AkarSoftware.Core.Entities.Abstract;
using AkarSoftware.DataAccess.Abstract;
using AkarSoftware.DataAccess.Concrete.EntityFramework.DbContexts;
using AkarSoftware.DataAccess.Concrete.EntityFramework.Repository;
using System.ComponentModel;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContexts _dbContexts;

        /// <summary>
        /// sadece propert olrak nasıl çağrılabileceği bir örnek oluşturulması maksadı ile eklenmiştir. işlevi yok 
        /// </summary>
        #region RepositoryProperties
        //public IGenderRepository GenderRepository => new EfGenderRepository(_dbContexts);
        #endregion

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

        /// <summary>
        /// Vermiş olduğunuz Entity ve O entity e hizmet eden Reposiytory nin fiziksel hali verildiğinde (abstract olmayan) sizlere otomatik olarak ilgili repsotiory nin instance ini verecektir. ek olarak buraya eklendi tek tek property çağrımanın önünge geçilebilmesi için 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TRepository"></typeparam>
        public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity , new() where TRepository : IEfGenericRepository<T>, new()
        {
            var repository = (TRepository)Activator.CreateInstance(typeof(TRepository), _dbContexts);
            return repository;
        }
    }
}
