using EveryParser.GrammarListener.CalculatorListener;
using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class TSequenceEqual
    {
        public static bool SequenceEqual<T>(this List<T> list1, List<T> list2)
        {
            if (list1 is null && list2 is null)
                return true;

            if (list1 is null || list2 is null)
                return false;

            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i += 1)
                if (!EqualityHelper.AreEqual(list1[i], list2[i]))
                    return false;

            return true;
        }

        public static bool SequenceEqual<T>(this List<T> list1, List<T> list2, IEqualityComparer<string> comparer)
        {
            if (list1 is null && list2 is null)
                return true;

            if (list1 is null || list2 is null)
                return false;

            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i += 1)
                if (!comparer.Equals(list1[i].ToString(), list2[i].ToString()))
                    return false;

            return true;
        }
    }
}