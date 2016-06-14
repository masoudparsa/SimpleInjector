using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BUser : BaseBusiness<Model.User>
    {
        Repository.Interfaces.IUserRepository _userRepository;
        Repository.Interfaces.IUnitOfWork _unitOfWork;
        public BUser(Repository.Interfaces.IUserRepository userRepository, Repository.Interfaces.IUnitOfWork unitOfWork):base(userRepository,unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public User SearchUser(int id)
        {

            User userObj = _userRepository.Search(id);
           
            return userObj;

        }
        public IList<User> SearchUser(string searchTerm)
        {
            
            return _userRepository.Search(searchTerm);
        }
    }
}
