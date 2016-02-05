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
    public class PersonRepositoryMongo //: IRepository<MongoPerson>
    {
        const string connectionString = "mongodb://localhost";
        MongoClient mongo;
        MongoServer server;

        public PersonRepositoryMongo()
        {
            mongo = new MongoClient();
            server = mongo.GetServer();
        }

        public void Create(MongoPerson item)
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
            var people = db.GetCollection<MongoPerson>("Person");
            people.Save(person);
        }

        public void Delete(MongoPerson item)
        {
            MongoDatabase db = server.GetDatabase("Person");
            var people = db.GetCollection<MongoPerson>("Person");
            //people.Find(item);

        }

        public IEnumerable<MongoPerson> GetAll()
        {
            MongoDatabase db = server.GetDatabase("Person");
            var people = db.GetCollection<MongoPerson>("Person");
            List<MongoPerson> result = new List<MongoPerson>();
            MongoCursor<MongoPerson> members = people.FindAll();
            foreach (MongoPerson p in members)
            {
                result.Add(p);
            }
            return result;
        }

        //public MongoPerson GetByID(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public MongoPerson GetByID(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public void Update(MongoPerson item)
        {
            throw new NotImplementedException();
        }
    }
}
