using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.DataAccess.Abstract.Dapper
{
    public interface IDpGenericRepository<T> where T : IEntity, new()
    {
        public void Add(T Entity);

    }
}
