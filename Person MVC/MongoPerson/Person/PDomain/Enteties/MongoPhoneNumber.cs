using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDomain.Enteties
{
    public class MongoPhoneNumber
    {
        [Key]
        public ObjectId Id { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberType { get; set; }
    }
}
