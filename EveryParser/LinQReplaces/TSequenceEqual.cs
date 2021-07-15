using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class TSequenceEqual
    {
        public static bool SequenceEqual<T>(this List<T> list1, List<T> list2)
        {
            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i += 1)
                if (!list1[i].Equals(list2[i]))
                    return false;

            return true;
        }

        public static bool SequenceEqual<T>(this List<T> list1, List<T> list2, IEqualityComparer<T> comparer)
        {
            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i += 1)
                if (!comparer.Equals(list1[i], list2[i]))
                    return false;

            return true;
        }
    }
}