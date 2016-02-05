using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPersistence;
using PDomain;
using PDomain.Enteties;
using MongoDB.Bson;

namespace PService
{
    public class PersonServices
    {
        //TODO: Change to Mapping
        //IRepository<Person> repository;
        PersonRepositoryMongo repository;

        public PersonServices()
        {
            //repository = new PersonRepositoryEF();
            //repository = new PersonRepositoryAdo();
            repository = new PersonRepositoryMongo();
        }

        public List<PersonViewModel> ReadAll()
        {
            List<MongoPerson> personR = repository.GetAll().ToList();
            return ToListViewModel(personR);
        }

        public PersonViewModel GetById(ObjectId id)
        {
            MongoPerson personP = repository.GetByID(id);
            return ToViewModel(personP);
        }

        public void Update(PersonViewModel person)
        {
            MongoPerson personR = FromViewModel(person);
            repository.Update(personR);
        }

        public void Add(PersonViewModel person)
        {
            MongoPerson personR = FromViewModel(person);
            repository.Create(personR);
        }

        public void Delete(PersonViewModel person)
        {
            MongoPerson personR = repository.GetByID(person.Id);
            repository.Delete(personR);
        }

        private List<PersonViewModel> ToListViewModel(List<MongoPerson> personR)
        {
            List<PersonViewModel> personVM = new List<PersonViewModel>();
            foreach (var item in personR)///Mapper
            {
                PersonViewModel p = ToViewModel(item);
                personVM.Add(p);
            }
            return personVM;
        }

        private PersonViewModel ToViewModel(MongoPerson personR)
        {
            PersonViewModel personVM = new PersonViewModel()
            {
                Id = personR.Id,
                FirstName = personR.FirstName,
                LastName = personR.LastName,
                Age = personR.Age,
                PhoneNumbers = new List<PhoneNumberViewModel>()
            };
            foreach (var pn in personR.phonenumbers)
            {
                personVM.PhoneNumbers.Add(new PhoneNumberViewModel()
                {
                    Id = pn.Id,
                    PhoneNumber = pn.PhoneNumber,
                    PhoneNumberType = pn.PhoneNumberType
                });
            }
            return personVM;
        }

        private MongoPerson FromViewModel(PersonViewModel person)
        {
            MongoPerson personR = new MongoPerson()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Age = person.Age,
                phonenumbers = new List<MongoPhoneNumber>()
            };
            foreach (var pn in person.PhoneNumbers)
            {
                if (pn.PhoneNumberType==null)
                {
                    throw new ArgumentException();
                }
                personR.phonenumbers.Add(new MongoPhoneNumber()
                {
                    Id=pn.Id,
                    PhoneNumber = pn.PhoneNumber,
                    PhoneNumberType=pn.PhoneNumberType,
                });
            }
            return personR;
        }
    }
}
