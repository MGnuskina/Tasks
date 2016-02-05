using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDomain
{
    public class Address
    {
        [Key]
        public virtual int ID { get; set; }
        [ForeignKey("person")]
        [Required]
        public virtual int PersonID { get; set; }
        [Required]
        public virtual int BuildingNumber { get; set; }
        public virtual int FlatNumber { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string Country { get; set; }

        public virtual Person person { get; set; }
        //[ForeignKey("street")]
        //[Required]
        //public int StreetID { get; set; }

        //public IList<Person> people { get; set; }

        //public Street street { get; set; }
    }
}
