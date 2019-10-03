using CaseGenesis.Models;
using EnterpriseContact.Domain.RelationManagement;
using AutoMapper;
using CaseGenesis.Areas.RelationArea.RequestModels;

namespace CaseGenesis.Profiles
{
    public class RelationProfile : Profile
    {
        public RelationProfile()
        {
            // ####################################################
            // Request model => Domain model
            // ####################################################

            CreateMap<RelationRequestModel, RelationModel>()
                    .ForPath(dest => dest.IdRelation, opt => opt.MapFrom(src => src.IdRelation))
                    .ForPath(dest => dest.IdPhysicalPerson, opt => opt.MapFrom(src => src.IdPhysicalPerson))
                    .ForPath(dest => dest.IdMoralPerson, opt => opt.MapFrom(src => src.IdMoralPerson));
        }
    }
}