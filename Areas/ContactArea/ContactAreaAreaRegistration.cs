using System.Web.Mvc;

namespace CaseGenesis.Areas.ContactArea
{
    public class ContactAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Contact";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName,
                AreaName + "/{controller}/{action}/{id}",
                new
                {
                    controller = "Contact",
                    action = "PingContactController",
                    id = UrlParameter.Optional,
                    culture = "BE"
                }
            );
        }
    }
}