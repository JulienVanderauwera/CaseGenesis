using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.RelationManagement
{
    public interface IRelationRepository
    {
        Guid? CreateRelation(RelationModel updateModel);
        bool DeleteRelation(Guid idRelation);
        bool DeleteRelationsByIdPerson(Guid idPerson);
    }
}
