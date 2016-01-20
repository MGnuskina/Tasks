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

        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(PersonCL.Person person)
        {
            repository.Create(person);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(PersonCL.Person person)
        {
            return RedirectToAction("AddPerson", person);
        }
    }
}