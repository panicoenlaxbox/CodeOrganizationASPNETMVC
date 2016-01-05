using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeOrganization.Models;

namespace CodeOrganization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomersRepository _customersRepository;

        public HomeController(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
    }
}