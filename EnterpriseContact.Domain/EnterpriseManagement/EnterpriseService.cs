using EnterpriseContact.Domain.AddressManagement;
using EnterpriseContact.Domain.RelationManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.EnterpriseManagement
{
    public class EnterpriseService : IEnterpriseService
    {
        private readonly IEnterpriseRepository _enterpriseRepository;
        private readonly IAddressService _addressService;
        private readonly IRelationService _relationService;

        public EnterpriseService(IEnterpriseRepository enterpriseRepository, IAddressService addressService, IRelationService relationService)
        {
            _enterpriseRepository = enterpriseRepository;
            _addressService = addressService;
            _relationService = relationService;
        }


        bool IEnterpriseService.CreateEnterprise(EnterpriseModel newEnterpriseModel)
        {            
            var idAddress = _addressService.CreateAddress(newEnterpriseModel.Address);
            var idPerson = _enterpriseRepository.CreateEnterprise(newEnterpriseModel);
            var idPersonAddress = _addressService.CreatePersonAddress(idAddress, idPerson, true);
            return idPersonAddress != null;
        }

        bool IEnterpriseService.DeleteEnteprise(Guid idPerson)
        {
            if (_addressService.DeleteAddressesByIdPerson(idPerson) && _relationService.DeleteRelationsByIdPerson(idPerson))
                return _enterpriseRepository.DeleteEnteprise(idPerson);
            else
                return false;
        }

        bool IEnterpriseService.UpdateEnterprise(EnterpriseModel updateModel)
        {
            return _enterpriseRepository.UpdateEnterprise(updateModel);
        }
    }
}
