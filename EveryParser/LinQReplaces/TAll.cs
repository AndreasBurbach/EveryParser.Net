using System;
using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class TAll
    {
        public static bool All<T>(this List<T> list, Func<T, bool> expression)
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));

            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            foreach (T value in list)
                if (!expression.Invoke(value))
                    return false;

            return true;
        }
    }
}