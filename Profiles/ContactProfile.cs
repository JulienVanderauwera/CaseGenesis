using AutoMapper;
using CaseGenesis.Areas.ContactArea.RequestModel;
using EnterpriseContact.Domain.ContactManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseGenesis.Profiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            // ####################################################
            // Request model => Domain model
            // ####################################################

            CreateMap<ContactRequestModel, ContactModel>()
                .ForPath(dest => dest.Address.Box, opt => opt.MapFrom(src => src.Box))
                .ForPath(dest => dest.Address.StreetName, opt => opt.MapFrom(src => src.StreetName))
                .ForPath(dest => dest.Address.CityName, opt => opt.MapFrom(src => src.CityName))
                .ForPath(dest => dest.Address.ZipCode, opt => opt.MapFrom(src => src.ZipCode))
                .ForPath(dest => dest.Address.Number, opt => opt.MapFrom(src => src.Number))
                .ForPath(dest => dest.Address.CountryName, opt => opt.MapFrom(src => src.CountryName))
                .ForPath(dest => dest.Address.IdAddress, opt => opt.MapFrom(src => src.IdAddress))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.IdPerson, opt => opt.MapFrom(src => src.IdPerson))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.VATNumber, opt => opt.MapFrom(src => src.VATNumber));
        }
    }
}