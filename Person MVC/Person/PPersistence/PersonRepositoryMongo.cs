using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using PDomain;
using MongoDB.Bson;
using PDomain.Enteties;

namespace PPersistence
{
    public class PersonRepositoryMongo : IRepository<Person>
    {
        const string connectionString = "mongodb://localhost";
        MongoClient mongo;
        MongoServer server;

        public PersonRepositoryMongo()
        {
            mongo = new MongoClient();
            server = mongo.GetServer();
        }

        public void Create(Person item)
        {
            MongoPerson person = new MongoPerson()
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                Age = item.Age,
                Id=new ObjectId(),
                phonenumbers = new List<MongoPhoneNumber>()//for one number
                {
                    new MongoPhoneNumber()
                    {
                        Id=new ObjectId(),
                        PhoneNumber=item.phonenumbers[0].PhoneNumber,
                        PhoneNumberType=item.phonenumbers[0].PhoneNumberType
                    }
                }
            };
            MongoDatabase db = server.GetDatabase("Person");
            var people = db.GetCollection<Person>("Person");
            person.phonenumbers[0].PersonID = person.Id;
            people.Save(person);
        }

        public void Delete(Person item)
        {
            MongoDatabase db = server.GetDatabase("Person");
            var people = db.GetCollection<Person>("Person");
        }

        public IEnumerable<Person> GetAll()
        {
            MongoDatabase db = server.GetDatabase("Person");
            var people = db.GetCollection<Person>("Person");
            List<Person> result = new List<Person>();
            MongoCursor<Person> members = people.FindAll();
            foreach (Person p in members)
            {
                result.Add(p);
            }
            return result;
        }

        public Person GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Person item)
        {
            throw new NotImplementedException();
        }
    }
}
