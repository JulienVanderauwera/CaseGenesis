using AutoMapper;
using CaseGenesis.Models;
using EnterpriseContact.Domain.Models;

namespace CaseGenesis.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            // ####################################################
            // Request model => Domain model
            // ####################################################

            CreateMap<AddressRequestModel, AddressModel>()
                    .ForPath(dest => dest.Box, opt => opt.MapFrom(src => src.Box))
                    .ForPath(dest => dest.StreetName, opt => opt.MapFrom(src => src.StreetName))
                    .ForPath(dest => dest.CityName, opt => opt.MapFrom(src => src.CityName))
                    .ForPath(dest => dest.ZipCode, opt => opt.MapFrom(src => src.ZipCode))
                    .ForPath(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
                    .ForPath(dest => dest.CountryName, opt => opt.MapFrom(src => src.CountryName))
                    .ForPath(dest => dest.IdAddress, opt => opt.MapFrom(src => src.IdAddress))
                    .ForPath(dest => dest.IsHeadquarters, opt => opt.MapFrom(src => src.IdAddress));
        }   
    }
}