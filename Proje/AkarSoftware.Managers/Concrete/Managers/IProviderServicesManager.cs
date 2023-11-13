using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.CostumeResults;
using AkarSoftware.DataAccess.Abstract;
using AkarSoftware.Dtos.Concrete.ProviderServicesDtos;
using AkarSoftware.Entities.Concrete;
using AkarSoftware.Managers.Abstract;
using AkarSoftware.Managers.Concrete.ConstVerables;
using AutoMapper;

namespace AkarSoftware.Managers.Concrete.Managers
{
    public class ProviderServicesManager : BaseManager, IProviderServicesService
    {
        public ProviderServicesManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<IDataResult<List<ListProviderServiceDto>>> GetAllServices()
        {
            var repository = _UnitOfWork.GetGenericRepostiory<ProviderServices>();
            var models = await repository.GetAllAsync();
            if (models.Count == 0)
                return new NotFoundDataResult<List<ListProviderServiceDto>>(Messages.Result.NotFound);

            var resultmodel = _Mapper.Map<List<ListProviderServiceDto>>(models);
            return new SuccessDataResult<List<ListProviderServiceDto>>(resultmodel);
        }
    }
}
