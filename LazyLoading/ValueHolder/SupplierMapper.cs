using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LazyLoading.ValueHolder
{
    public class SupplierMapper
    {
        public Supplier Load(int supplierId)
        {
            Supplier supplier = new Supplier(supplierId, new ValueHolder<IEnumerable<Product>>(new ProductLoader()));

            return supplier;
        }

        private class ProductLoader : IValueLoader<IEnumerable<Product>>
        {
            public IEnumerable<Product> load()
            {
                Random random = new Random();

                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(2000);
                    yield return new Product(random.Next(0, 1000));
                }
            }
        }
    }
}
