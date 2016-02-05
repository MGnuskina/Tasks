using Microsoft.AspNet.Identity;
using PService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserPersonMVC.Controllers
{
    public class UserController : Controller
    {
        IUserService service;

        public UserController(IUserService serv)
        {
            service = serv;
        }

        public UserController()
        {
            service = new UserService();
        }

        public ActionResult Index()
        {
            string ID = User.Identity.GetUserId();
            UserViewModel user = service.GetById(ID);
            return View(user);
        }

        [HttpPost]
        public ActionResult Index(UserViewModel user)
        {
            service.UpdateUserData(user);
            return RedirectToAction("Index");
        }

        public ActionResult People()
        {
            UserViewModel user = service.GetById(User.Identity.GetUserId());
            return View(user);
        }

        [HttpPost]
        public ActionResult People(UserViewModel user)
        {
            service.Update(user);
            return RedirectToAction("People");
        }

        public ActionResult AddPerson()
        {
            PersonViewModel person= new PersonViewModel();
            person.UserID = User.Identity.GetUserId();
            return PartialView(person);
        }

        [HttpPost]
        public ActionResult AddPerson(PersonViewModel person/*, FormCollection collection*/)
        {
            UserViewModel user = service.GetById(person.UserID);
            user.people.Add(person);
            //person.PhoneNumbers = new List<PhoneNumberViewModel>();
            //for (int i = 4; i < collection.Count - 1; i = i + 2)
            //{
            //    if (collection[i] != "" && collection[i + 1] != "")
            //    {
            //        PhoneNumberViewModel phone = new PhoneNumberViewModel()
            //        {
            //            PhoneNumber = collection[i],
            //            PhoneNumberType = collection[i + 1]
            //        };
            //        person.PhoneNumbers.Add(phone);
            //    }
            //}
            //service.Add(person);
            service.Update(user);
            return RedirectToAction("People");
        }

        public ActionResult Edit(int PersonID)
        {
            PersonViewModel person = service.GetPersonById(PersonID);
            return PartialView(person);
        }

        [HttpPost]
        public ActionResult Edit(PersonViewModel person)
        {
            service.UpdatePerson(person);
            return RedirectToAction("People");
        }

        public ActionResult Delete(int PersonID)
        {
            PersonViewModel per = service.GetPersonById(PersonID);
            return PartialView(per);
        }

        [HttpPost]
        public ActionResult Delete(PersonViewModel person)
        {
            //UserViewModel user = service.GetById(person.UserID);
            //user.people.Remove(person);
            //service.Update(user);
            service.DeletePerson(person);
            return RedirectToAction("People");
        }
    }
}