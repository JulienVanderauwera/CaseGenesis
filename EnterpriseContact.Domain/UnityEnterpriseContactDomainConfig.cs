using EnterpriseContact.Domain.AddressManagement;
using EnterpriseContact.Domain.ContactManagement;
using EnterpriseContact.Domain.EnterpriseManagement;
using EnterpriseContact.Domain.RelationManagement;
using Microsoft.Practices.Unity;

namespace EnterpriseContact.Domain
{
    public class UnityEnterpriseContactDomainConfig
    {
        public static void RegisterComponents(UnityContainer container)
        {
            container.RegisterType<IAddressService, AddressService>();
            container.RegisterType<IEnterpriseService, EnterpriseService>();
            container.RegisterType<IContactService, ContactService>();
            container.RegisterType<IRelationService, RelationService>();
        }
    }
}
