using System.Data.Entity;
using System.Web.Mvc;
using AutoMapper;
using EnterpriseContact.Domain;
using EnterpriseContact.Infra.Repositories;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace CaseGenesis
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            UnityEnterpriseContactRepositoriesConfig.RegisterComponents(container);
            UnityEnterpriseContactDomainConfig.RegisterComponents(container);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles(typeof(UnityConfig));
                cfg.AddProfiles(typeof(UnityEnterpriseContactRepositoriesConfig));
            });
            var mapper = config.CreateMapper();

            container.RegisterInstance(mapper);
        }
    }
}