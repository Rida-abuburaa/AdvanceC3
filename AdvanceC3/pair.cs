using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceC3
{
    internal class pair<Tkey , Tvalue>
    {
        public Tkey Key { get; set; }
        public Tvalue Value { get; set; }

        public pair(Tkey key, Tvalue value)
        {
            Key = key;
            Value = value;
        }
    }
}
