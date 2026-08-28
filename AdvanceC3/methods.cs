using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceC3
{
    internal class methods
    {
        public void swap<T>(ref T a , ref T b)
        {
            T temp = a ;
            a = b;
            b = temp;
        }

    }
}
