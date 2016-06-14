﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ISearchRepository<T> 
    {
        T Search(int id);
        IList<T> Search(string searchTerm);

    }
}
