﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCL
{
    public class PersonRepositoryEF : IRepository<Person>
    {
        PersonContextEntitySQL db = new PersonContextEntitySQL();

        public void Create(Person item)
        {
            db.Persons.Add(item);
            db.SaveChanges();
        }

        public void Delete(Person item)
        {
            db.Persons.Remove(item);
            db.SaveChanges();
        }

        public IEnumerable<Person> GetAll()
        {
            return db.Persons.ToList();
        }

        public Person GetByID(int id)
        {
            return db.Persons.Find(id);
        }

        public void Update(Person item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
