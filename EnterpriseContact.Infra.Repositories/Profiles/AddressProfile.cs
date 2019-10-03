using AutoMapper;
using EnterpriseContact.Domain.Models;
using EnterpriseContact.Infra.Entities;

namespace EnterpriseContact.Infra.Repositories.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
                CreateMap<AddressModel, Address>()
                   .ForPath(dest => dest.Box, opt => opt.MapFrom(src => src.Box))
                   .ForPath(dest => dest.StreetName, opt => opt.MapFrom(src => src.StreetName))
                   .ForPath(dest => dest.CityName, opt => opt.MapFrom(src => src.CityName))
                   .ForPath(dest => dest.ZipCode, opt => opt.MapFrom(src => src.ZipCode))
                   .ForPath(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
                   .ForPath(dest => dest.CountryName, opt => opt.MapFrom(src => src.CountryName)); ;            
        }
    }
}
