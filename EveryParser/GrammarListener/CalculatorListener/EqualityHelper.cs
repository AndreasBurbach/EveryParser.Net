using EveryParser.LinQReplaces;
using System;
using System.Collections.Generic;

namespace EveryParser.GrammarListener.CalculatorListener
{
    internal static class EqualityHelper
    {
        public static bool AreEqual(object obj1, object obj2)
        {
            if (obj1 == null && obj2 == null) return true;
            if (obj1 == null || obj2 == null) return false;

            if (obj1 is List<object> list1 && obj2 is List<object> list2)
                return list1.SequenceEqual(list2);
            else if (obj1 is string str1 && obj2 is string str2)
                return str1.Equals(str2, StringComparison.Ordinal);
            else if (TypeCheckHelper.IsNumber(obj1) && TypeCheckHelper.IsNumber(obj2))
                return Convert.ToDecimal(obj1) == Convert.ToDecimal(obj2);
            else if (TypeCheckHelper.IsBoolean(obj1) && TypeCheckHelper.IsBoolean(obj2))
                return Convert.ToBoolean(obj1) == Convert.ToBoolean(obj2);
            else if (TypeCheckHelper.IsDateTime(obj1) && TypeCheckHelper.IsDateTime(obj2))
                return Convert.ToDateTime(obj1) == Convert.ToDateTime(obj2);
            else
                return obj1.Equals(obj2);
        }
    }
}
