using System;
using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class TAll
    {
        public static bool All<T>(this List<T> list, Func<T, bool> expression)
        {
            foreach (T value in list)
                if (!expression.Invoke(value))
                    return false;

            return true;
        }
    }
}