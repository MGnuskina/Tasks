using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Person.Controllers
{
    public class PersonsController : Controller
    {
        PersonCL.PersonRepository repository = new PersonCL.PersonRepository();
        // GET: Persons
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult EditPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditPerson(PersonCL.Person person)
        {
            repository.Create(person);
            return RedirectToAction("Index");
        }
    }
}