using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseContact.Domain.Models;

namespace EnterpriseContact.Domain.AddressManagement
{
    public interface IAddressRepository
    {
        Guid? CreateAddress(AddressModel address);
        bool DeleteAddressesByIdPerson(Guid idPerson);
        bool UpdateAddress(AddressModel address);
        Guid? CreatePersonAddress(Guid? idAddress, Guid? idPerson, bool isHeadQuarters = false);
        bool SetAsHeadquarters(Guid idAddress, Guid idPerson);
    }
}
