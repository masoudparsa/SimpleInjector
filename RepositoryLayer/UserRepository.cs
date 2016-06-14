using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository.Interfaces;
using System.Data.Entity;

namespace Repository
{
    public class UserRepository : BaseRepository<User> ,  Interfaces.IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
            
        }

        public IList<User> Search(string searchTerm)
        {
            //throw new NotImplementedException();
            return new List<User>();
        }

        public User Search(int id)
        {
            return new User();
            //throw new NotImplementedException();
        }
    }
}
