using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class User 
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Person Perosn { get; set; }

    }
}
