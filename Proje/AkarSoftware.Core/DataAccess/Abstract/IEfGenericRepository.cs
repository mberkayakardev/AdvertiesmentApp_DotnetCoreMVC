using AkarSoftware.Core.DataAccess.Concrete.ComplexTypes;
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
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = true, Expression<Func<T, object>> OrderByProperty = null, OrderByEnum order = OrderByEnum.Descending, params Expression<Func<T, object>>[] IncludeProperties); // ORder By Key ile birlikte yapılabilmesi açısından eklenmiş bir değerdir. 
        Task<T> GetAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = false, Expression<Func<T, object>> OrderBy = null, OrderByEnum order = OrderByEnum.Descending, params Expression<Func<T, object>>[] IncludeProperties); // Order By bu etapta sıralamaya göre ilk değerin alınması istenirse diye eklenmiştir.
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
        IQueryable<T> GetAsQueryable();


    }
}
