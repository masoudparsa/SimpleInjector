using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public abstract class BaseBusiness<T> :Interfaces.IBaseBusiness<T> where T :class
    {
        Repository.Interfaces.IUnitOfWork _unitOfWork;
        Repository.Interfaces.IBaseRepository<T> _repository;
        public BaseBusiness(Repository.Interfaces.IBaseRepository<T> repository, Repository.Interfaces.IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        //public void Create(T entity)
        //{
        //    if (entity == null)
        //    {
        //        throw new ArgumentNullException("entity");
        //    }
        //    _repository.Add(entity);
        //    _unitOfWork.Commit();
        //}

        //public void Delete(T entity)
        //{
        //    if (entity == null) throw new ArgumentNullException("entity");
        //    _repository.Delete(entity);
        //    _unitOfWork.Commit();
        //}

        //public IEnumerable<T> GetAll()
        //{
        //    return _repository.GetAll();
        //}

        //public void Update(T entity)
        //{
        //    if (entity == null) throw new ArgumentNullException("entity");
        //    _repository.Edit(entity);
        //    _unitOfWork.Commit();
        //}


        
    }
}
