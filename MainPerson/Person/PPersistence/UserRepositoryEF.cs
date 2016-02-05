using PDomain;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPersistence
{
    public class UserRepositoryEF : IUserRepository<User>
    {
        private IRepository<Person> personRepository;
        private UserContextEntitySQL db = new UserContextEntitySQL();

        public UserRepositoryEF()
        {
            personRepository = new PersonRepositoryEF();
        }

        public void Create(User item)
        {
            db.Users.Add(item);
            //user has no person on creation....
            db.SaveChanges();
        }

        public void Delete(User item)
        {
            item = GetByID(item.ID);
            db.Users.Remove(item);
            db.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
        {
            IEnumerable<User> users = db.Users.ToList();
            return users;
        }

        public User GetByID(string id)
        {
            return db.Users.Find(id);
        }

        public Person GetPersonByID(int Id)
        {
            return db.Persons.Find(Id);
        }

        public void Update(User item)
        {
            //db.Entry(item).State = System.Data.Entity.EntityState.Added;//Modified;//.Added;//Modified
            db.Set<User>().AddOrUpdate(item);
            db.SaveChanges();

            //User itemsInDb = GetByID(item.ID);
            //if (item.people.Count >= itemsInDb.people.Count)
            //{
            //    for (int i = 0; i < itemsInDb.people.Count; i++)
            //    {
            //        UpdatePersonInUser(item.people[i]);
            //    }
            //    for (int i = itemsInDb.people.Count; i < item.people.Count; i++)
            //    {
            //        personRepository.Create(item.people[i]);
            //    }
            //}
            //else
            //{
            //    for (int i = itemsInDb.people.Count - 1; i > item.people.Count; i--)
            //    {
            //        db.Persons.Remove(itemsInDb.people[i]);
            //        //personRepository.Delete(itemsInDb.people[i]);
            //    }
            //    for (int i = 0; i < item.people.Count; i++)
            //    {
            //        UpdatePersonInUser(item.people[i]);
            //    }
            //}
            //db.SaveChanges();
        }

        private void UpdatePersonInUser(Person person)
        {
            personRepository.Update(person);
        }

        public void UpdateUserData(User item)
        {
            User itemsInDb = GetByID(item.ID);
            itemsInDb.FirstName = item.FirstName;
            itemsInDb.LastName = item.LastName;
            itemsInDb.LogInName = item.LogInName;
            db.Entry(itemsInDb).State = System.Data.Entity.EntityState.Modified;           
            db.SaveChanges();
        }

        public void UpdatePerson(Person person)
        {
            User user = GetByID(person.UserID);
            int i = 0;
            while (user.people.Count > i && user.people[i].ID != person.ID)
            {
                i++;
            }
            if (i == user.people.Count)
            {
                throw new ArgumentException();
            }
            db.Entry(user.people[i]).State= System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeletePerson(Person person)
        {
            person = GetPersonByID(person.ID);
            db.Persons.Remove(person);
            db.SaveChanges();
        }
    }
}
