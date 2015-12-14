using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading.Ghost
{
    public class DataSourceGhost
    {
        internal static void Load(Department domainObject)
        {
            Console.WriteLine("Loading department.");
            throw new NotImplementedException();
        }

        internal static void Load(Employee domainObject)
        {
            Console.WriteLine("Loading employee.");
            throw new NotImplementedException();
        }

        internal static void Load(DomainObject domainObject)
        {
            throw new NotImplementedException();
        }
    }
}
