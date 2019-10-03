using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.EnterpriseManagement
{
    public interface IEnterpriseService
    {
        bool CreateEnterprise(EnterpriseModel newContactModel);
        bool UpdateEnterprise(EnterpriseModel updateModel);
        bool DeleteEnteprise(Guid idPerson);
    }
}
