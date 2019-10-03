using AutoMapper;
using EnterpriseContact.Domain.RelationManagement;
using EnterpriseContact.Infra.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Infra.Repositories.RelationManagement
{
    public class RelationRespository : IRelationRepository
    {
        private readonly EnterpriseContactDBContext _context;
        private readonly IMapper _mapper;

        public RelationRespository(EnterpriseContactDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        Guid? IRelationRepository.CreateRelation(RelationModel newRelationModel)
        {
            var relationEntity = _mapper.Map<Relation>(newRelationModel);
            _context.Relation.Add(relationEntity);

             if (_context.SaveChanges() > 0)
                return relationEntity.IdRelation;
            else return null;
        }

        bool IRelationRepository.DeleteRelation(Guid idRelation)
        {
            var relationEntity = _context.Relation.FirstOrDefault(x => x.IdRelation == idRelation);
            _context.Relation.Remove(relationEntity);

            return _context.SaveChanges() > 0;
        }

        bool IRelationRepository.DeleteRelationsByIdPerson(Guid idPerson)
        {
            var relationEntities = _context.Relation.Where(x => x.IdMoralePerson == idPerson || x.IdPhysicalPerson== idPerson);
            if (relationEntities.Any())
            {
                _context.Relation.RemoveRange(relationEntities);
                return _context.SaveChanges() > 0;
            }
            return true;
            
        }
    }
}
