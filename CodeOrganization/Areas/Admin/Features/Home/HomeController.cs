using System.Web.Mvc;

namespace CodeOrganization.Areas.Admin.Features.Home
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Home feature (area)";
            return View();
        }
    }
}