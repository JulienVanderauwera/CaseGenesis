using EnterpriseContact.Domain.AddressManagement;
using EnterpriseContact.Domain.ContactManagement;
using EnterpriseContact.Domain.EnterpriseManagement;
using EnterpriseContact.Domain.RelationManagement;
using EnterpriseContact.Infra.Repositories.AddressManagement;
using EnterpriseContact.Infra.Repositories.ContactManagement;
using EnterpriseContact.Infra.Repositories.EnterpriseManagement;
using EnterpriseContact.Infra.Repositories.RelationManagement;
using Microsoft.Practices.Unity;

namespace EnterpriseContact.Infra.Repositories
{
    public class UnityEnterpriseContactRepositoriesConfig
    {
        public static void RegisterComponents(UnityContainer container)
        {
            container.RegisterType<IAddressRepository, AddressRepository>();
            container.RegisterType<IEnterpriseRepository, EnterpriseRepository>();
            container.RegisterType<IContactRepository, ContactRepository>();
            container.RegisterType<IRelationRepository, RelationRespository>();

            container.RegisterType<EnterpriseContactDBContext>(new HierarchicalLifetimeManager());
        }
    }
}
