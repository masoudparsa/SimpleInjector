using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IUserRepository :IBaseRepository<Model.User>, ISearchRepository<Model.User>
    {
        
    }
}
