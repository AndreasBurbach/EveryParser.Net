using System;
using System.Collections.Generic;

namespace EveryParser.Compare
{
    /// <summary>
    /// https://docs.microsoft.com/de-de/dotnet/api/system.linq.enumerable.sequenceequal?view=net-5.0#System_Linq_Enumerable_SequenceEqual__1_System_Collections_Generic_IEnumerable___0__System_Collections_Generic_IEnumerable___0__System_Collections_Generic_IEqualityComparer___0__
    /// </summary>
    internal class StringIgnoreCaseComparer : IEqualityComparer<object>
    {
        public new bool Equals(object x, object y)
        {
            //Check whether the compared objects reference the same data.
            if (ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;

            //Check whether the strings are equal.
            return x.ToString().Equals(y.ToString(), StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode(object x)
        {
            return x.ToString().GetHashCode();
        }
    }
}