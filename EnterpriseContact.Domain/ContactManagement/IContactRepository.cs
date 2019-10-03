using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.ContactManagement
{
    public interface IContactRepository
    {
        Guid? CreateContact(ContactModel newContactModel);
        bool DeleteContact(Guid idPerson);
        bool UpdateContact(ContactModel contactModel);
    }
}
