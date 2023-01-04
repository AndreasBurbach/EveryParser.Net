using System.Collections.Generic;

namespace EveryParser.LinQReplaces
{
    public static class TReverse
    {
        public static List<T> ToReverse<T>(this List<T> list)
        {
            if (list is null)
                throw new System.ArgumentNullException(nameof(list));

            var resultArray = new T[list.Count];
            list.CopyTo(resultArray);

            var result = new List<T>(resultArray);
            result.Reverse();

            return result;
        }

        public static string ToReverse(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            var resultArray = new char[text.Length];
            text.CopyTo(0, resultArray, 0, text.Length);

            var result = new List<char>(resultArray);
            result.Reverse();

            return new string(result.ToArray());
        }
    }
}