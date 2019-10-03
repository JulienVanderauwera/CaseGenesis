using System.Web.Mvc;

namespace CaseGenesis.Areas.AddressArea
{
    public class AddressAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Address";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName,
                AreaName + "/{controller}/{action}/{id}",
                new
                {
                    controller = "Address",
                    action = "PingAddressController",
                    id = UrlParameter.Optional,
                    culture = "BE"
                }
            );
        }
    }
}