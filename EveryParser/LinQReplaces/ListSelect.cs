using System;
using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class ListSelect
    {
        public static List<TResult> Select<T1, TResult>(this List<T1> list, Func<T1, TResult> expression)
        {
            var result = new List<TResult>(list.Count);
            foreach (T1 value in list)
                result.Add(expression.Invoke(value));

            return result;
        }
    }
}