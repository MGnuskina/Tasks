using MVCGameApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGameApplication.Controllers
{
    public class AutorisationController : Controller
    {
        // GET: Autorisation
        public ActionResult Index()
        {
            return View();
        }

        public AutorisationController()
        {

        }

        [HttpPost]
        public ActionResult LogIn(/*UseerLogInViewModel model, string returnUrl*/)
        {
            return View();
        }

    }
}