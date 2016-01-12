using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class Person:IComparable
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(int id, string firstName, string lastName, int age)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            Person pers = (Person)obj;
            return (this.ID - pers.ID);
        }
    }
}
