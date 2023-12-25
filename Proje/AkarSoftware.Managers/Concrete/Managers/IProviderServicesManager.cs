using AkarSoftware.Core.DataAccess.Concrete.ComplexTypes;
using AkarSoftware.Core.Utilities.Results.BaseResults;
using AkarSoftware.Core.Utilities.Results.CostumeResults;
using AkarSoftware.DataAccess.Abstract;
using AkarSoftware.Dtos.Concrete.ProviderServicesDtos;
using AkarSoftware.Entities.Concrete;
using AkarSoftware.Managers.Abstract;
using AkarSoftware.Managers.Concrete.ConstVerables;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Design.Internal;
using static AkarSoftware.Managers.Concrete.ConstVerables.Messages;

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
            var models = await repository.GetAllAsync( orderBy: x=> x.OrderByDescending(y=> y.ListOrder).ThenByDescending(z=> z.CreatedDate));
            if (models.Count == 0)
                return new NotFoundDataResult<List<ListProviderServiceDto>>(Messages.Result.NotFound);

            var resultmodel = _Mapper.Map<List<ListProviderServiceDto>>(models);
            return new SuccessDataResult<List<ListProviderServiceDto>>(resultmodel, CRUD.Read);
        }
    }
}
