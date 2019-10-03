using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseContact.Domain.Models;

namespace EnterpriseContact.Domain.AddressManagement
{
    public interface IAddressService
    {
        Guid? CreateAddress(AddressModel address);
        bool UpdateAddress(AddressModel address);
        bool DeleteAddressesByIdPerson(Guid idPerson);
        Guid? CreatePersonAddress(Guid? idAddress, Guid? idPerson, bool isHeadQuarters= false);
        bool AddAddressToEnterprise(AddressModel addressModel, Guid idPerson);
        bool SetAsHeadquarters(Guid idAddress, Guid idPerson);
    }
}
