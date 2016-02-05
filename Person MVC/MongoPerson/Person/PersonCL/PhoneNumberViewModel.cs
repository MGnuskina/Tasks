using MongoDB.Bson;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace PService
{
    public class PhoneNumberViewModel
    {
        [Key]
        public ObjectId Id { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberType { get; set; }
    }
}
