using System.Web.Mvc;

namespace CodeOrganization.Areas.Admin.Features.Users
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
    }
}