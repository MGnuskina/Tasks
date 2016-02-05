using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PService
{
    public class AddressViewModel
    {
        [Key]
        public int Id { get; set; }
        //public int personID { get; set; }
        public int BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        //[Required]
        //public virtual int StreetID { get; set; }
        ////[Required]
        ////public string Street { get; set; }
        ////[Required]
        ////public string City { get; set; }
        ////[Required]
        ////public string Country { get; set; }
        //[Required]
        //public string BuildingNumber { get; set; }
        //public string FlatNumber { get; set; }

        //public StreetViewModel street { get; set; }
    }
}
