using AutoMapper;
using EnterpriseContact.Domain.EnterpriseManagement;
using EnterpriseContact.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Infra.Repositories.EnterpriseManagement
{
    public class EnterpriseRepository : IEnterpriseRepository
    {
        private readonly EnterpriseContactDBContext _context;
        private readonly IMapper _mapper;

        public EnterpriseRepository(EnterpriseContactDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        Guid? IEnterpriseRepository.CreateEnterprise(EnterpriseModel newContactModel)
        {
            var enterpriseEntity = _mapper.Map<MoralPerson>(newContactModel);
            _context.MoralPerson.Add(enterpriseEntity);
            if (_context.SaveChanges() > 0)
                return enterpriseEntity.IdPerson;
            else return null;        
        }

        bool IEnterpriseRepository.DeleteEnteprise(Guid idPerson)
        {
            var personEntity = _context.Person.OfType<MoralPerson>().FirstOrDefault(x => x.IdPerson == idPerson);
            _context.MoralPerson.Remove(personEntity);
            _context.Person.Remove(personEntity);

            return _context.SaveChanges() > 0;
        }

        bool IEnterpriseRepository.UpdateEnterprise(EnterpriseModel updateModel)
        {
            var newEnterpriseEntity = _mapper.Map<MoralPerson>(updateModel);
            var oldEnterpriseEntity = _context.Person.OfType<MoralPerson>().FirstOrDefault(x => x.IdPerson == updateModel.IdPerson);
            _context.Entry(oldEnterpriseEntity).CurrentValues.SetValues(newEnterpriseEntity);

            return _context.SaveChanges() > 0;
        }
    }
}
