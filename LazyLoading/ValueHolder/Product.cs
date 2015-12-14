using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading.ValueHolder
{
    public class Product
    {
        public int ProductID { get; set; }

        public Product(int productId)
        {
            ProductID = productId;
        }
    }
}
