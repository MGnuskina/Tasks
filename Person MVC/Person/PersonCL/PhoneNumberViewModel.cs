using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace PService
{
    public class PhoneNumberViewModel
    {
        [Key]
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberType { get; set; }

        
    }
}
