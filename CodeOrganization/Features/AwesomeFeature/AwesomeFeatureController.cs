using System.Web.Mvc;

namespace CodeOrganization.Features.AwesomeFeature
{
    public class AwesomeFeatureController : Controller
    {
        // GET: AwesomeFeature
        public ActionResult Index()
        {
            ViewBag.Title = "Awesome feature";
            return View();
        }
    }
}