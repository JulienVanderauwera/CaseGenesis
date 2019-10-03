using System.Web.Mvc;

namespace CaseGenesis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult DoesThisWork()
        {
            var model = "Yes, it does";
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
