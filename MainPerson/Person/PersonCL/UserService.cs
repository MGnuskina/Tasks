using PDomain;
using PPersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PService
{
    public class UserService : IUserService
    {
        IUserRepository<User> repository;

        public UserService()
        {
            Mapper.CreateMap<User, UserViewModel>();
            Mapper.CreateMap<UserViewModel, User>();
            Mapper.CreateMap<Address, AddressViewModel>();
            Mapper.CreateMap<AddressViewModel, Address>();
            Mapper.CreateMap<Person, PersonViewModel>();
            Mapper.CreateMap<PersonViewModel, Person>();
            Mapper.CreateMap<List<User>, List<UserViewModel>>();
            Mapper.CreateMap<List<UserViewModel>, List<User>>();
            //Mapper.CreateMap<Street, StreetViewModel>();
            //Mapper.CreateMap<StreetViewModel, Street>();
            //Mapper.CreateMap<City, CityViewModel>();
            //Mapper.CreateMap<CityViewModel, City>();
            //Mapper.CreateMap<Country, CountryViewModel>();
            //Mapper.CreateMap<CountryViewModel, Country>();
            Mapper.CreateMap<PhoneNumbers, PhoneNumberViewModel>();
            Mapper.CreateMap<PhoneNumberViewModel, PhoneNumbers>();
            Mapper.CreateMap<List<PhoneNumbers>, List<PhoneNumberViewModel>>();
            Mapper.CreateMap<List<PhoneNumberViewModel>, List<PhoneNumbers>>();
            Mapper.CreateMap<List<Address>, List<AddressViewModel>>();
            Mapper.CreateMap<List<AddressViewModel>, List<Address>>();
            Mapper.CreateMap<List<Person>, List<PersonViewModel>>();
            Mapper.CreateMap<List<PersonViewModel>, List<Person>>();
            repository = new UserRepositoryEF();
        }

        public void Add(UserViewModel user)
        {
            User userR = Mapper.Map<User>(user);
            repository.Create(userR);
        }

        public void Delete(UserViewModel user)
        {
            User userR = Mapper.Map<User>(user);
            repository.Delete(userR);
        }

        public UserViewModel GetById(string id)
        {
            User user = repository.GetByID(id);
            UserViewModel userVM = Mapper.Map<UserViewModel>(user);
            userVM.people = new List<PersonViewModel>();
            foreach (var per in user.people)
            {
                userVM.people.Add(Mapper.Map<PersonViewModel>(per));
                userVM.people[userVM.people.Count - 1].Address = new List<AddressViewModel>();
                foreach (var add in per.addresses)
                {
                    userVM.people[userVM.people.Count - 1].Address.Add(Mapper.Map<AddressViewModel>(add));
                }
                userVM.people[userVM.people.Count - 1].PhoneNumbers = new List<PhoneNumberViewModel>();
                foreach (var ph in per.phonenumbers)
                {
                    userVM.people[userVM.people.Count - 1].PhoneNumbers.Add(Mapper.Map<PhoneNumberViewModel>(ph));
                }
            }
            return userVM;
        }

        public PersonViewModel GetPersonById(int id)
        {
            Person person = repository.GetPersonByID(id);
            PersonViewModel personVM = Mapper.Map<PersonViewModel>(person);
            personVM.Address = new List<AddressViewModel>();
            foreach (var add in person.addresses)
            {
                personVM.Address.Add(Mapper.Map<AddressViewModel>(add));
            }
            personVM.PhoneNumbers = new List<PhoneNumberViewModel>();
            foreach (var ph in person.phonenumbers)
            {
                personVM.PhoneNumbers.Add(Mapper.Map<PhoneNumberViewModel>(ph));
            }
            return personVM;
        }

        public List<UserViewModel> ReadAll()
        {
            List<User> users = repository.GetAllUsers().ToList();
            List<UserViewModel> usersVM = Mapper.Map<List<UserViewModel>>(users);
            return usersVM;
        }

        public void Update(UserViewModel user)
        {
            User userR = Mapper.Map<User>(user);
            userR.people = new List<Person>();
            foreach (var per in user.people)
            {
                userR.people.Add(Mapper.Map<Person>(per));
                userR.people[userR.people.Count - 1].addresses = new List<Address>();
                foreach (var add in per.Address)
                {
                    userR.people[userR.people.Count - 1].addresses.Add(Mapper.Map<Address>(add));
                }
                userR.people[userR.people.Count - 1].phonenumbers = new List<PhoneNumbers>();
                foreach (var ph in per.PhoneNumbers)
                {
                    userR.people[userR.people.Count - 1].phonenumbers.Add(Mapper.Map<PhoneNumbers>(ph));
                }
            }
            repository.Update(userR);
        }

        public void UpdateUserData(UserViewModel user)
        {
            User userR = Mapper.Map<User>(user);
            repository.UpdateUserData(userR);
        }

        public void UpdatePerson(PersonViewModel person)
        {
            Person personR = ToPerson(person);
            repository.UpdatePerson(personR);
        }

        public void DeletePerson(PersonViewModel person)
        {
            Person personR = ToPerson(GetPersonById(person.Id));
            repository.DeletePerson(personR);
        }

        #region Mapping
        public Person ToPerson(PersonViewModel person)
        {
            Person personR = Mapper.Map<Person>(person);
            personR.addresses = new List<Address>();
            foreach (var add in person.Address)
            {
                personR.addresses.Add(Mapper.Map<Address>(add));
            }
            personR.phonenumbers = new List<PhoneNumbers>();
            foreach (var ph in person.PhoneNumbers)
            {
                personR.phonenumbers.Add(Mapper.Map<PhoneNumbers>(ph));
            }
            return personR;
        }
        #endregion
    }
}
