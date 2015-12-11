using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LazyLoading.LazyInitialization
{
    public class DataSource
    {
        public static IEnumerable<Order> GetOrders(int customerId)
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                yield return new Order(random.Next(0, 1000));
            }
        }
    }
}
