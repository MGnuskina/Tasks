using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Person.Controllers
{
    public class PersonsController : Controller
    {
        //PersonCL.PersonRepositoryEF repository = new PersonCL.PersonRepositoryEF();

        PersonCL.PersonRepositoryAdo repository = new PersonCL.PersonRepositoryAdo();

        // GET: Persons
        public ActionResult Index()
        {
            Models.PersonsViewModel per = null;
            try
            {
                per = new Models.PersonsViewModel() { People = repository.GetAll() };
            }
            catch
            {
                throw new ArgumentException("The DB can't be found");
            }
            return View(per);
        }

        [HttpPost]
        public ActionResult Index(Models.PersonsViewModel persons)//IEnumerable<PersonCL.Person> persons)
        {
            try
            {
                foreach (PersonCL.Person person in persons.People)
                {
                    repository.Update(person);
                }
            }
            catch
            {
                throw new ArgumentException();
            }
            return View(repository.GetAll());
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(PersonCL.Person person)
        {
            try
            {
                repository.Create(person);
            }
            catch
            {
                throw new ArgumentException();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Person.Models.PersonViewModel Person)
        {
            //Models.PersonViewModel per = new Models.PersonViewModel() { FirstName = personInUse.FirstName, LastName = personInUse.LastName, Age = personInUse.Age };
            return View(Person);
        }

        [HttpPost]
        public ActionResult Edit(PersonCL.Person person)
        {
            try
            {
                repository.Update(person);
            }
            catch
            {
                throw new ArgumentException("No such field in the DB");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(PersonCL.Person person)
        {
            Person.Models.PersonViewModel per = new Models.PersonViewModel() { Id = person.ID, Age=person.Age, FirstName=person.FirstName, LastName=person.LastName };
            return View(per);
        }

        [HttpPost]
        public ActionResult Delete(Person.Models.PersonViewModel person)
        {
            try
            {
                repository.Delete(repository.GetByID(person.Id));
            }
            catch
            {
                throw new ArgumentException();
            }
            return RedirectToAction("Index");
        }
    }
}