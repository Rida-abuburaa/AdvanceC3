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
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;
            else
                return b;
        }
    }
}
