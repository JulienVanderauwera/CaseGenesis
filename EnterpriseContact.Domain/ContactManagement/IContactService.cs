using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.ContactManagement
{
    public interface IContactService
    {
        bool CreateContact(ContactModel newContactModel);
        bool UpdateContact(ContactModel newContactModel);
        bool DeleteContact(Guid idPerson);
    }
}
