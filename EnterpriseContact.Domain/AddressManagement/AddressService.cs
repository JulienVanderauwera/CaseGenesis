using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseContact.Domain.EnterpriseManagement;
using EnterpriseContact.Domain.Models;

namespace EnterpriseContact.Domain.AddressManagement
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        bool IAddressService.AddAddressToEnterprise(AddressModel addressModel, Guid idPerson)
        {
            var idAddress = _addressRepository.CreateAddress(addressModel);
            return _addressRepository.CreatePersonAddress(idAddress, idPerson) != null;
        }

        Guid? IAddressService.CreateAddress(AddressModel address)
        {
            return _addressRepository.CreateAddress(address);
        }

        Guid? IAddressService.CreatePersonAddress(Guid? idAddress, Guid? idPerson, bool isHeadQuarters = false)
        {
            return _addressRepository.CreatePersonAddress(idAddress, idPerson, isHeadQuarters);
        }

        bool IAddressService.DeleteAddressesByIdPerson(Guid idPerson)
        {
            return _addressRepository.DeleteAddressesByIdPerson(idPerson);
        }

        bool IAddressService.SetAsHeadquarters(Guid idAddress, Guid idPerson)
        {
                return _addressRepository.SetAsHeadquarters(idAddress, idPerson);
        }

        bool IAddressService.UpdateAddress(AddressModel address)
        {
            if (address.IdAddress != null)
                return _addressRepository.UpdateAddress(address);
            else return false;  
        }
    }
}
