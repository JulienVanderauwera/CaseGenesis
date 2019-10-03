using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.RelationManagement
{
    public class RelationService : IRelationService
    {
        private readonly IRelationRepository _relationRepository;

        public RelationService(IRelationRepository relationRepository)
        {
            _relationRepository = relationRepository;
        }
        bool IRelationService.CreateRelation(RelationModel newRelationModel)
        {
            return _relationRepository.CreateRelation(newRelationModel) != null;
        }

        bool IRelationService.DeleteRelation(Guid idRelation)
        {
            return _relationRepository.DeleteRelation(idRelation);
        }

        bool IRelationService.DeleteRelationsByIdPerson(Guid idPerson)
        {
            return _relationRepository.DeleteRelationsByIdPerson(idPerson);
        }
    }
}
