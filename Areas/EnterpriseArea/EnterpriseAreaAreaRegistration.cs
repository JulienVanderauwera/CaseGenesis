using System.Web.Mvc;

namespace CaseGenesis.Areas.EnterpriseArea
{
    public class EnterpriseAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Enterprise";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName,
                AreaName + "/{controller}/{action}/{id}",
                new
                {
                    controller = "Enterprise",
                    action = "PingEnterpriseController",
                    id = UrlParameter.Optional,
                    culture = "BE"
                }
            );
        }
    }
}