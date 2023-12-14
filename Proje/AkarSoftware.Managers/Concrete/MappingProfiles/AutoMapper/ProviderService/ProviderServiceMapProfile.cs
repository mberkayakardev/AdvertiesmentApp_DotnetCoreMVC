using AkarSoftware.Dtos.Concrete.ProviderServicesDtos;
using AkarSoftware.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Managers.Concrete.MappingProfiles.AutoMapper.ProviderService
{
    public class ProviderServiceMapProfile : Profile
    {
        public ProviderServiceMapProfile()
        {
            CreateMap<ListProviderServiceDto, ProviderServices>().ReverseMap();
        }
    }
}
