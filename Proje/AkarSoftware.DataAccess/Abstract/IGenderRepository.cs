using AkarSoftware.Core.DataAccess.Abstract;
using AkarSoftware.Core.Entities.Concrete;

namespace AkarSoftware.DataAccess.Abstract
{
    /// <summary>
    /// 
    /// Gender entitymiz esasında bir LookUpTable olmasına rağmen burada Eklenmesinin sebebi Costume bir repository yazımı için bir örnek oluşturabilmektir. Fiziksel bir kullanım değildir. sadece örnek 
    /// 
    /// </summary>
    public interface IGenderRepository : IEfGenericRepository<Gender>
    {
        /// <summary>
        /// Example methodu esasında bir işlevsel method değildir. Entity bazlı özel bir reposiytory method oluşturmak istendiğinde örnek bazlı bir method olarak eklenmiştir. 
        /// </summary>
        /// <returns></returns>
        Task Example(); 
    }
}
