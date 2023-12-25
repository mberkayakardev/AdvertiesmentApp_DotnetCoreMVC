using AkarSoftware.Core.DataAccess.Abstract.Dapper;
using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.DataAccess.Concrete.Dapper
{
    // ilgili interface i oluşturup implemente edilmemiş olup sadece senaryo kurgulanabilirliği açısından ilgili class yerleştirildi. 
    // Contrib Kütüphanesi ile kullanılabilir bir senaryodur.
    public class DpGenericRepository<T> : IDpGenericRepository<T> where T : class, IEntity, new()
    {
        public void Add(T Entity)
        {

        }
    }
}
