using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class UC1
    {
        public T Findmax<T>(T x,T y,T z) where T : IComparable
        {
            if (x.CompareTo(y) > 0 && x.CompareTo(z) > 0)
            {
                return x;

            }
            if (y.CompareTo(x) > 0 && y.CompareTo(z) > 0)
            {
                return y;
            }
            else
            {
                return z;
            }
        }
    }
}
