using EnterpriseContact.Domain.AddressManagement;
using EnterpriseContact.Domain.RelationManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.ContactManagement
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IAddressService _addressService;
        private readonly IRelationService _relationService;
        public ContactService(IContactRepository contactRepository, IAddressService addressService, IRelationService relationService)
        {
            _contactRepository = contactRepository;
            _addressService = addressService;
            _relationService = relationService;
        }
        bool IContactService.CreateContact(ContactModel newContactModel)
        {
            var idAddress = _addressService.CreateAddress(newContactModel.Address);
            var idPerson = _contactRepository.CreateContact(newContactModel);
            var idPersonAddress = _addressService.CreatePersonAddress(idAddress, idPerson);
            return idPersonAddress != null;
        }

        bool IContactService.DeleteContact(Guid idPerson)
        {
            if (_addressService.DeleteAddressesByIdPerson(idPerson) && _relationService.DeleteRelationsByIdPerson(idPerson))
                return _contactRepository.DeleteContact(idPerson);
            else
                return false;
        }

        bool IContactService.UpdateContact(ContactModel contactModel)
        {
            var result = false;
            if (contactModel.IdPerson != null)
            {
                if (_addressService.UpdateAddress(contactModel.Address))
                    return _contactRepository.UpdateContact(contactModel);
                else
                    return false;
            }
            return result;
        }
    }
}
