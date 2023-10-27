using AkarSoftware.Core.Entities.Abstract;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AkarSoftware.Core.DataAccess.Abstract
{
    public interface IEfGenericRepository<T> where T : class, IEntity, new()
    {
        Task CreateAsync(T Entity);
        Task UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = true, params Expression<Func<T, object>>[] IncludeProperties);
        Task<T> GetAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = false, params Expression<Func<T, object>>[] IncludeProperties);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
        IQueryable<T> GetAsQueryable();


    }
}
