using System.Web.Mvc;

namespace CaseGenesis.Areas.RelationArea
{
    public class RelationAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Relation";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName,
                AreaName + "/{controller}/{action}/{id}",
                new
                {
                    controller = "Relation",
                    action = "PingRelationController",
                    id = UrlParameter.Optional,
                    culture = "BE"
                }
            );
        }
    }
}