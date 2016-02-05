using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDomain
{
    public class PhoneNumbers
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("person")]
        public int PersonID { get; set; }
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
        public string PhoneNumberType { get; set; }

        public Person person { get; set; }

    }
}
