using System;
using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class TSelect
    {
        public static List<TResult> Select<T1, TResult>(this List<T1> list, Func<T1, TResult> expression)
        {
            var result = new List<TResult>(list.Count);
            foreach (T1 value in list)
                result.Add(expression.Invoke(value));

            return result;
        }

        public static List<TResult> Select<T1, TResult>(this IEnumerable<T1> enumerable, Func<T1, TResult> expression)
        {
            var result = new List<TResult>();
            foreach (T1 value in enumerable)
                result.Add(expression.Invoke(value));

            return result;
        }
    }
}