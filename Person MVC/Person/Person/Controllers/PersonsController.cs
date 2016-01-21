using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Person.Controllers
{
    public class PersonsController : Controller
    {
        //PersonCL.PersonRepositoryEF repository = new PersonCL.PersonRepositoryEF();//entity

        PersonCL.PersonRepositoryAdo repository = new PersonCL.PersonRepositoryAdo();//ado

        // GET: Persons
        public ActionResult Index()
        {
            List<Models.PersonViewModel> per = new List<Models.PersonViewModel>();
            List<PersonCL.Person> p = repository.GetAll().ToList();
            foreach (var pers in p)
            {
                per.Add(new Models.PersonViewModel() { Id = pers.ID, Age = pers.Age, FirstName = pers.FirstName, LastName = pers.LastName });
            }
            return View(per);
        }

        [HttpPost]
        public ActionResult Index(List<Models.PersonViewModel> per)
        {
            foreach (Models.PersonViewModel person in per)
            {
                PersonCL.Person p = new PersonCL.Person() { ID = person.Id, Age = person.Age, FirstName = person.FirstName, LastName = person.LastName };
                PersonCL.Person tmpPerson = repository.GetByID(p.ID);
                if (tmpPerson.Age != p.Age || tmpPerson.FirstName != p.FirstName || tmpPerson.LastName != p.LastName)
                {
                    tmpPerson = null;
                    repository.Update(p);
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult SaveAll(List<PersonCL.Person> per)
        {
            foreach (PersonCL.Person person in per)
            {
                repository.Update(person);
            }
            return RedirectToAction("Index");
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
            Person.Models.PersonViewModel per = new Models.PersonViewModel() { Id = person.ID, Age = person.Age, FirstName = person.FirstName, LastName = person.LastName };
            return View(per);
        }

        [HttpPost]
        public ActionResult Delete(Person.Models.PersonViewModel person)
        {
            repository.Delete(repository.GetByID(person.Id));
            return RedirectToAction("Index");
        }
    }
}