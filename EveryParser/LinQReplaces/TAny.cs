using System;
using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class TAny
    {
        public static bool Any<T>(this List<T> list)
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

        public static bool Any<TKey, TValue>(this SortedList<TKey, TValue> list)
        {
            return list.Count > 0;
        }


        public static bool Any<T>(this T[] array)
        {
            return array.Length > 0;
        }

        public static bool Any<T>(this T[] array, Func<T, bool> expression)
        {
            foreach (var x in array)
                if (expression.Invoke(x))
                    return true;

            return false;
        }
    }
}