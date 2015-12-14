using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading.ValueHolder
{
    public class Supplier
    {
        private ValueHolder<IEnumerable<Product>> products;
        private int supplierId;

        public int SupplierID
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        public IEnumerable<Product> Products
        {
            get
            {
                return products.Value;
            }
        }

        public Supplier(int supplierId, ValueHolder<IEnumerable<Product>> productValueHolder)
        {
            this.supplierId = supplierId;
            this.products = productValueHolder;
        }
    }
}
