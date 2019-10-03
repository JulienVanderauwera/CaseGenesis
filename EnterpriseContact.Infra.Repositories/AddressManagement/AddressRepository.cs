using AutoMapper;
using EnterpriseContact.Domain.AddressManagement;
using EnterpriseContact.Domain.Models;
using EnterpriseContact.Infra.Entities;
using Microsoft.Practices.ObjectBuilder2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Infra.Repositories.AddressManagement
{
    public class AddressRepository : IAddressRepository
    {
        private readonly EnterpriseContactDBContext _context;
        private readonly IMapper _mapper;

        public AddressRepository(EnterpriseContactDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        Guid? IAddressRepository.CreateAddress(AddressModel address)
        {
            var addressEntity = _mapper.Map<Address>(address);
            _context.Address.Add(addressEntity);
            if (_context.SaveChanges() > 0)
                return addressEntity.IdAddress;
            else return null;
        }

        Guid? IAddressRepository.CreatePersonAddress(Guid? idAddress, Guid? idPerson, bool isHeadQuarters = false)
        {
            var personAddressEntity = new PersonAddress
            {
                IdPerson = idPerson ?? Guid.Empty,
                IdAddress = idAddress ?? Guid.Empty,
                IsHeadquarters = isHeadQuarters
                
            };
            _context.PersonAddress.Add(personAddressEntity);

            if (_context.SaveChanges() > 0)
                return personAddressEntity.IdPersonAddress;
            else return null;
        }

        bool IAddressRepository.DeleteAddressesByIdPerson(Guid idPerson)
        {
            var personAddresses = _context.PersonAddress.Where(x => x.IdPerson == idPerson);
            if (personAddresses.Any())
            {
                var adresses = _context.Address.Where(a => personAddresses.Select(x => x.IdAddress).Contains(a.IdAddress));
                _context.Address.RemoveRange(adresses);
                _context.PersonAddress.RemoveRange(personAddresses);

                return _context.SaveChanges() > 0;

            }
            return true;
        }

        bool IAddressRepository.SetAsHeadquarters(Guid idAddress, Guid idPerson)
        {
            if (_context.Person.OfType<MoralPerson>().FirstOrDefault(x => x.IdPerson == idPerson)!=null)
            {
                var personAddresses = _context.PersonAddress.Where(x => x.IdPerson == idPerson);
                personAddresses.ForEach(x => x.IsHeadquarters = false);
                var headQuartersEntity = _context.PersonAddress.FirstOrDefault(x => x.IdPerson == idPerson && x.IdAddress == idAddress);
                headQuartersEntity.IsHeadquarters = true;
                return _context.SaveChanges() > 0; 
            }
            return false;
        }

        bool IAddressRepository.UpdateAddress(AddressModel address)
        {
            var newAddressEntity = _mapper.Map<Address>(address);
            var oldAddressEntity = _context.Address.FirstOrDefault(x => x.IdAddress == address.IdAddress);
            _context.Entry(oldAddressEntity).CurrentValues.SetValues(newAddressEntity);

            return _context.SaveChanges() > 0;
        }
    }
}
