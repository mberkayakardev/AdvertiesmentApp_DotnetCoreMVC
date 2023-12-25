using AkarSoftware.Core.DataAccess.Abstract.EntityFramework;
using AkarSoftware.Core.DataAccess.Concrete.ComplexTypes;
using AkarSoftware.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AkarSoftware.Core.DataAccess.Concrete.EntityFramework
{
    public class EfGenericRepository<T> : IEfGenericRepository<T> where T : class, IEntity, new()
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<T> _entity;
        public EfGenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entity = _dbContext.Set<T>();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            var result = await _entity.AnyAsync(predicate);
            return result;
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return (predicate == null) ? await _entity.CountAsync() : await _entity.CountAsync(predicate);
        }

        public async Task CreateAsync(T Entity)
        {
            await _entity.AddAsync(Entity);
        }

        public async Task DeleteAsync(T Entity)
        {
            await Task.Run(() =>
            {
                _entity.Remove(Entity);
            });
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = true, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _entity;
            if (IncludeProperties != null)

                foreach (var item in IncludeProperties)
                    query = query.Include(item);

            if (AsNoTracking == true)
                query = query.AsNoTracking();

            if (where != null)
                query = query.Where(where);

            if (orderBy != null)
                query = orderBy(query);

         

            return await query.ToListAsync();
        }

        public IQueryable<T> GetAsQueryable()
        {
            return _entity.AsQueryable();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = false, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _entity;
            if (IncludeProperties != null)

                foreach (var item in IncludeProperties)
                    query = query.Include(item);

            if (where != null)
                query = query.Where(where);

            if (orderBy != null)
            {
                query = orderBy(query);
            }


            if (AsNoTracking == true)
                query = query.AsNoTracking();

            return await query.FirstOrDefaultAsync();

        }

        public async Task UpdateAsync(T Entity)
        {
            await Task.Run(() => { _entity.Update(Entity); });
        }
    }
}
