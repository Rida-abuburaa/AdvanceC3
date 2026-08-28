using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceC3
{
    internal class Repository<T>: IRepository<T>
    {
        public void Add(T item)
        {
            Console.WriteLine("Item added");
        }

        public T Get(int id)
        {
            return default(T);
        }
    }
}
