using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDomain.Enteties
{
    public class MongoPhoneNumber
    {
        public ObjectId Id { get; set; }
        public ObjectId PersonID { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberType { get; set; }

        public Person person { get; set; }
    }
}
