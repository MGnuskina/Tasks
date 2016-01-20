using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PersonCL
{
    public class PersonContextEntitySQL: DbContext //IContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
