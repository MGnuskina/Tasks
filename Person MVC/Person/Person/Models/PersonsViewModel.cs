using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Person.Models
{
    public class PersonsViewModel
    {
        public IEnumerable<PersonCL.Person> People { get; set; } = new List<PersonCL.Person>();
    }
}