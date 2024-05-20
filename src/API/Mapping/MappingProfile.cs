using API.Contracts;
using API.Models;
using AutoMapper;

namespace API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MakeResource, Make>().ReverseMap().ForMember(dest => dest.Models, opt => opt.MapFrom(src => src.Models));
        }
    }
}