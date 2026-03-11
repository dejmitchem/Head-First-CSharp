using System;
using System.Collections.Generic;
using System.Text;

namespace DuckList
{
    class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck? x, Duck? y)
        {
            if (x == null || y == null) return 0;
            if (x.Kind > y.Kind) return 1;
            if (x.Kind < y.Kind) return -1;
            return 0;
        }
    }
}
