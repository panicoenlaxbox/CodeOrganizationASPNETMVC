using System.Web.Mvc;

namespace CodeOrganization.Areas.Admin.Features.Users
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            ViewBag.Title = "Users feature (area)";            
            return View();
        }
    }
}