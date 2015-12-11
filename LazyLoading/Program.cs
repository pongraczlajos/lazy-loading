using LazyLoading.LazyInitialization;
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
                Console.WriteLine("B: Lazy Initialization native.");
                Console.WriteLine("C: Virtual Proxy.");
                Console.WriteLine("D: Value Holder.");
                Console.WriteLine("E: Ghost.");
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
                        break;
                    case 'c':
                        Image image = new VirtualProxyImage("teddy-bear.jpg");
                        image.Display();
                        break;
                    case 'd':
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
