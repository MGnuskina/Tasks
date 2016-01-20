using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonClassLibrary
{
    public interface IPersonRepository<T>
    {
        void Create(T item);
        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Update(T item);
        void Delete(T item);
    }
}
