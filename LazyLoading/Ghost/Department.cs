using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading.Ghost
{
    public class Department : DomainObject
    {
        public Department(int id) : base(id)
        {
            Load();
        }
    }
}
