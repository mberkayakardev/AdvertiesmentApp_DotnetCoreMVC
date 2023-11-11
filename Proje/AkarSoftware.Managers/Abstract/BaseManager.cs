using AkarSoftware.DataAccess.Abstract;
using AutoMapper;

namespace AkarSoftware.Managers.Abstract
{
    public class BaseManager 
    {
        protected readonly IMapper _Mapper;
        protected readonly IUnitOfWork _UnitOfWork;
        public BaseManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }
    }
}
