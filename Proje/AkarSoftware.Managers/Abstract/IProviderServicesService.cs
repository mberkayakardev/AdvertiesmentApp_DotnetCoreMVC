using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Dtos.Concrete.ProviderServicesDtos;

namespace AkarSoftware.Managers.Abstract
{
    public interface IProviderServicesService
    {
        /// <summary>
        ///  Şirket kapsamındaki tüm verilecek hizmetler ilgili alanda listelenecektir. 
        /// </summary>
        Task<IDataResult<List<ListProviderServiceDto>>> GetAllServices();
    }
}
