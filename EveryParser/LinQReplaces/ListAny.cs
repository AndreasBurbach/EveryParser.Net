using System;
using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class ListAny
    {
        public static bool Any(this List<object> list)
        {
            return list.Count > 0;
        }

        public static bool Any<T>(this List<T> list, Func<T, bool> expression)
        {
            foreach (var x in list)
                if (expression.Invoke(x))
                    return true;

            return false;
        }
    }
}