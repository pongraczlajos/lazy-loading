using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading.LazyInitialization
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        private IEnumerable<Order> orders;

        public IEnumerable<Order> Orders
        {
            get
            {
                if (orders == null)
                {
                    Console.WriteLine("Lazy initialization of orders for customer {0}.", CustomerID);
                    orders = DataSource.GetOrders(CustomerID);
                }

                return orders;
            }
        }

        public Customer(int id, string name)
        {
            CustomerID = id;
            Name = name;
        }
    }
}
