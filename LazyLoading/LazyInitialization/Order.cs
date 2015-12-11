using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading.LazyInitialization
{
    public class Order
    {
        public int OrderID { get; set; }

        public Order(int orderId)
        {
            OrderID = orderId;
        }
    }
}
