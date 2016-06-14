using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    
    public class BPerson :BaseBusiness<Person>
    {
        
        Repository.Interfaces.IPersonRepository _personRepository;
        Repository.Interfaces.IUserRepository _userRepository;
        Repository.Interfaces.IUnitOfWork _unitOfWork;
        public BPerson(Repository.Interfaces.IPersonRepository personRepository, Repository.Interfaces.IUserRepository userRepository,Repository.Interfaces.IUnitOfWork unitOfWork):base(personRepository,unitOfWork)
        {
            
            _personRepository = personRepository;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        
        }
       

        public  Person SearchPerson(int id)
        {
            
            Person personObj = _personRepository.Search(id);
            User userObj = _userRepository.GetById(1);
            if(userObj!=null)
            personObj.UserList.Add(userObj);
            return personObj;
            
        }
        public IList<Person> SearchPerson(string searchTerm)
        {
            
            return _personRepository.Search(searchTerm);
        }

        public void AddPerson()
        {

        }
    }
}
