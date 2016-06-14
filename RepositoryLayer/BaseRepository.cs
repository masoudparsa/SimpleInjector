using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;

namespace Repository
{
    public abstract class BaseRepository<T> :  Interfaces.IBaseRepository<T> where T : class
    {
        protected DbContext _context;
        protected IDbSet<T> _dbset;
        public BaseRepository(DbContext context)
        {
            _context = context;
           _dbset = _context.Set<T>();
        }
        
        public virtual void Add(T entity)
        {
            _dbset.Add(entity);
            
        }

        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual IEnumerable<T> Find(Func<T, bool> predicate)
        {
            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual IEnumerable<T> GetAll()
        {
            //throw new NotImplementedException();
             return _dbset.AsEnumerable<T>();
        }

        public virtual T GetById(int Id)
        {
            //throw new NotImplementedException();
               return _dbset.Find(Id);
        }

        public void Save()
        {
            
            _context.SaveChanges();
        }

        
    }
}
