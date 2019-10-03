using AutoMapper;
using EnterpriseContact.Domain.RelationManagement;
using EnterpriseContact.Infra.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Infra.Repositories.Profiles
{
    public class RelationProfile : Profile
    {
        public RelationProfile()
        {
            // ####################################################
            // Request model => Domain model
            // ####################################################

            CreateMap<RelationModel, Relation>()
                    .ForPath(dest => dest.IdRelation, opt => opt.MapFrom(src => src.IdRelation))
                    .ForPath(dest => dest.IdPhysicalPerson, opt => opt.MapFrom(src => src.IdPhysicalPerson))
                    .ForPath(dest => dest.IdMoralePerson, opt => opt.MapFrom(src => src.IdMoralPerson));
        }
    }
}
