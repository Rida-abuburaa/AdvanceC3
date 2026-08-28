using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceC3
{
    internal class Container<T>
    {
        private T value;
        public void Add(T value)
        {
            this.value = value;
        }


        public T Get()
        {
            return value;

        }
    }
}
