using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading.ValueHolder
{
    public class ValueHolder<T>
    {
        private T value;

        private IValueLoader<T> loader;

        public T Value
        {
            get
            {
                if (value == null)
                {
                    value = loader.load();
                }

                return value;
            }
        }

        public ValueHolder(IValueLoader<T> loader)
        {
            this.loader = loader;
        }
    }
}
