using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PersonRepository : BaseRepository<Model.Person>,  Interfaces.IPersonRepository
    {
        
        public PersonRepository(Context context):base(context)
        {
           
        }
        public IList<Person> GetPersonsByPaging()
        {
            //throw new NotImplementedException();
            return new List<Person>();
        }

        public IList<Person> Search(string searchTerm)
        {
            //throw new NotImplementedException();
            return new List<Person>();
        }

        public Person Search(int id)
        {
            //throw new NotImplementedException();
            return new Person();
        }


        
    }
}
