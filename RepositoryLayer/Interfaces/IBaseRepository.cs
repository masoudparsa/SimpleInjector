using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
   public interface IBaseRepository<T> where T :class
    {
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        T GetById(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);
        void Save();
    }
}
