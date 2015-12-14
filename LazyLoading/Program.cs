using LazyLoading.Ghost;
using LazyLoading.LazyInitialization;
using LazyLoading.ValueHolder;
using LazyLoading.VirtualProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            var isRunning = true;

            do
            {
                Console.WriteLine("A: Lazy Initialization.");
                Console.WriteLine("B: Virtual Proxy.");
                Console.WriteLine("C: Value Holder.");
                Console.WriteLine("D: Ghost.");
                Console.WriteLine("Q: quit.");

                Console.Write("Enter option: ");
                var key = Console.ReadKey();
                Console.WriteLine();

                switch (key.KeyChar)
                {
                    case 'a':
                        Customer customer = new Customer(1, "Martin");

                        foreach (Order order in customer.Orders)
                        {
                            Console.WriteLine("Got order {0} for customer {1}.", order.OrderID, customer.Name);
                        }
                        break;
                    case 'b':
                        Image image = new VirtualProxyImage("teddy-bear.jpg");
                        image.Display();
                        break;
                    case 'c':
                        SupplierMapper mapper = new SupplierMapper();
                        Supplier supplier = mapper.Load(10);

                        foreach (Product product in supplier.Products)
                        {
                            Console.WriteLine("Got product {0} for supplier {1}.", product.ProductID, supplier.SupplierID);
                        }
                        break;
                    case 'd':
                        Employee employee = new Employee(5);
                        break;
                    case 'q':
                        isRunning = false;
                        break;
                }

                Console.WriteLine();
            } while (isRunning);
        }
    }
}
