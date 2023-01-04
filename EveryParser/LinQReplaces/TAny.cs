using System;
using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class TAny
    {
        public static bool Any<T>(this List<T> list)
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));

            return list.Count > 0;
        }

        public static bool Any<T>(this List<T> list, Func<T, bool> expression)
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));

            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            foreach (var x in list)
                if (expression.Invoke(x))
                    return true;

            return false;
        }

        public static bool Any<TKey, TValue>(this SortedList<TKey, TValue> list)
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));

            return list.Count > 0;
        }

        public static bool Any<T>(this T[] array)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            return array.Length > 0;
        }

        public static bool Any<T>(this T[] array, Func<T, bool> expression)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            foreach (var x in array)
                if (expression.Invoke(x))
                    return true;

            return false;
        }
    }
}