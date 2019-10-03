using AutoMapper;
using EnterpriseContact.Domain.ContactManagement;
using EnterpriseContact.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Infra.Repositories.ContactManagement
{
    public class ContactRepository : IContactRepository
    {
        private readonly EnterpriseContactDBContext _context;
        private readonly IMapper _mapper;

        public ContactRepository(EnterpriseContactDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        Guid? IContactRepository.CreateContact(ContactModel newEnterpriseModel)
        {
            var personEntity = _mapper.Map<PhysicalPerson>(newEnterpriseModel);
            _context.PhysicalPerson.Add(personEntity);
            if (_context.SaveChanges() > 0)
                return personEntity.IdPerson;
            else return null;
        }

        bool IContactRepository.DeleteContact(Guid idPerson)
        {
            var personEntity = _context.Person.OfType<PhysicalPerson>().FirstOrDefault(x => x.IdPerson == idPerson);
            _context.PhysicalPerson.Remove(personEntity);
            _context.Person.Remove(personEntity);

            return _context.SaveChanges() > 0;
        }

        bool IContactRepository.UpdateContact(ContactModel updateModel)
        {
            var newContactEntity = _mapper.Map<PhysicalPerson>(updateModel);
            var oldContactEntity = _context.Person.OfType<PhysicalPerson>().FirstOrDefault(x => x.IdPerson == updateModel.IdPerson);
            _context.Entry(oldContactEntity).CurrentValues.SetValues(newContactEntity);

            return _context.SaveChanges() > 0;
        }
    }
}
