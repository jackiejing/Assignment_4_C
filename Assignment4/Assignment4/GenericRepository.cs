using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        List<T> List = new List<T>();
        public void Add(T item)
        {
            List.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return List;
        }

        public T GetById(int id)
        {
            return List.Find(id);
        }

        public void Remove(T item)
        {
            List.Remove(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
