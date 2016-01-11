using Autorization;
using MVCGameApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGameApplication.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(UserLogInViewModel model)
        {
            GameRequestViewModel game = new GameRequestViewModel();
            game.UserName = model.Name;
            game.UserPassword = model.Password;
            return View(game);
        }

        [HttpPost]
        public ActionResult Index(GameRequestViewModel model)
        {
            return RedirectToAction("Index", "Game", model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Users(UserLogInViewModel model)
        {
            return View(model);
        }


    }
}