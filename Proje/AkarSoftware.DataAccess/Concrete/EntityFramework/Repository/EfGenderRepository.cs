using AkarSoftware.Core.DataAccess.Concrete.EntityFramework;
using AkarSoftware.Core.Entities.Concrete;
using AkarSoftware.DataAccess.Abstract;
using AkarSoftware.DataAccess.Concrete.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Repository
{
    public class EfGenderRepository : EfGenericRepository<Gender>, IGenderRepository
    {
        public EfGenderRepository(MyDbContexts contexts) : base(contexts) 
        {
        }
        /// <summary>
        /// İşlevsellik yok sadece deneme amaçlı eklenmiştir. 
        /// </summary>
        /// <returns></returns>
        public async Task Example()
        {
            // Costume repository kodu ekleyebilirisn sorgu, işlev vs vs.
        }
    }
}
