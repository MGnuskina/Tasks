using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPersistence;
using PDomain;

namespace PService
{
    public class PersonServices
    {
        //TODO: Change to Mapping
        IRepository<Person> repository;

        public PersonServices()
        {
            repository = new PersonRepositoryEF();
            //repository = new PersonRepositoryAdo();
            //repository = new PersonRepositoryMongo();
        }

        public PersonServices(IRepository<PDomain.Person> pr)
        {
            repository = pr;
        }

        public List<PersonViewModel> ReadAll()
        {
            List<Person> personR = repository.GetAll().ToList();
            return ToListViewModel(personR);
        }

        public PersonViewModel GetById(int id)
        {
            try
            {
                Person personP = repository.GetByID(id);
                return ToViewModel(personP);
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        public void Update(PersonViewModel person)
        {
            try
            {
                Person personR = FromViewModel(person);
                repository.Update(personR);
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        public void Add(PersonViewModel person)
        {
            try
            {
                Person personR = FromViewModel(person);
                repository.Create(personR);
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        public void Delete(PersonViewModel person)
        {
            try
            {
                Person personR = repository.GetByID(person.Id);
                repository.Delete(personR);
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        private List<PersonViewModel> ToListViewModel(List<Person> personR)
        {
            List<PersonViewModel> personVM = new List<PersonViewModel>();
            foreach (var item in personR)///Mapper
            {
                PersonViewModel p = ToViewModel(item);
                personVM.Add(p);
            }
            return personVM;
        }

        private PersonViewModel ToViewModel(Person personR)
        {
            PersonViewModel personVM = new PersonViewModel()
            {
                Id = personR.ID,
                FirstName = personR.FirstName,
                LastName = personR.LastName,
                Age = personR.Age,
                PhoneNumbers = new List<PhoneNumberViewModel>()
            };
            foreach (var pn in personR.phonenumbers)
            {
                personVM.PhoneNumbers.Add(new PhoneNumberViewModel()
                {
                    Id = pn.ID,
                    PhoneNumber = pn.PhoneNumber,
                    PhoneNumberType = pn.PhoneNumberType
                });
            }
            return personVM;
        }

        private Person FromViewModel(PersonViewModel person)
        {
            Person personR = new Person()
            {
                ID = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Age = person.Age,
                phonenumbers = new List<PhoneNumbers>()
            };
            foreach (var pn in person.PhoneNumbers)
            {
                if (pn.PhoneNumberType == null)
                {
                    throw new ArgumentException();
                }
                personR.phonenumbers.Add(new PhoneNumbers()
                {
                    ID = pn.Id,
                    PersonID = person.Id,
                    PhoneNumber = pn.PhoneNumber,
                    PhoneNumberType = pn.PhoneNumberType,
                });
            }
            return personR;
        }
    }
}
