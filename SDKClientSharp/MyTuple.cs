using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDKClientSharp
{
    class MyTuple<T1, T2>
    {
        public MyTuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public T1 Item1 { get; }
        public T2 Item2 { get; }
    }
}
