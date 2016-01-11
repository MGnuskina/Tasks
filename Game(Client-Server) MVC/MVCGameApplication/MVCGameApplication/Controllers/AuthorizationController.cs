using Autorization;
using MVCGameApplication;
using MVCGameApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGameApplication.Controllers
{
    public class AuthorizationController : Controller
    {
        
        // GET: Autorisation
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(UserLogInViewModel model)
        {
            if (ModelState.IsValid && PlayerRepository.AuthorizationCheck(model.Name, model.Password)!=null)
            {
                return RedirectToAction("LogInSuccess", model);
            }
            else
            {
                ViewBag.Error= "Wrong name or password!";
                return View();
            }
        }

        public ActionResult LogInSuccess(UserLogInViewModel model)
        {
            return RedirectToAction("Index", "Home", model);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserRegisterViewModel model)
        {
            if (ModelState.IsValid && PlayerRepository.AuthorizationCheck(model.Name)==null)
            {
                Player player = new Player(model.Name, model.Password);
                PlayerRepository.Create(player);
                return RedirectToAction("LogIn");
            }
            else
            {
                ViewBag.Error="The user already exists!";
                return View(model);
            }
        }


    }
}