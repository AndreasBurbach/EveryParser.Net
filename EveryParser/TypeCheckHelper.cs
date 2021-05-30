using System.Collections.Generic;
using System.Linq;

namespace EveryParser
{
    internal static class TypeCheckHelper
    {
        /// <summary>
        /// Checks if all objects are type of List(object)
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        internal static bool IsArrayOfObjectList(object[] objs) => !objs.Any(obj => !(obj is List<object>));

        /// <summary>
        /// Checks if all objects are type of boolean
        /// </summary>
        /// <param name="objs"></param>
        internal static bool IsArrayOfBoolean(object[] objs) => !objs.Any(obj => !bool.TryParse(obj.ToString(), out _));

        /// <summary>
        /// Checks if all objects are type of string or List(string)
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        internal static bool IsStringOrStringList(object[] objs) => !objs.Any(obj => !(obj is string || (obj is List<object> list && list.All(x => x is string))));

        /// <summary>
        /// Checks if all objects are type of string or List(object)
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        internal static bool IsStringOrList(object[] objs) => !objs.Any(obj => !(obj is string || obj is List<object> list));

        /// <summary>
        /// Checks if all objects are type of List(number)
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        internal static bool IsArrayOfNumberList(object[] objs) => !objs.Any(obj => !(obj is List<object> list && list.All(x => x is int || x is long || x is double || x is decimal)));

        /// <summary>
        /// Checks if all objects are type of number and/or List(number)
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        internal static bool IsArrayOfNumberOrNumberList(object[] objs) =>
            !objs.Any(obj => !(obj is int || obj is long || obj is double || obj is decimal ||
            (obj is List<object> list && list.All(x => x is int || x is long || x is double || x is decimal))));

        /// <summary>
        /// Checks if all objects are type of number
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        internal static bool IsArrayOfNumber(object[] objs) => !objs.Any(obj => !(obj is int || obj is long || obj is double || obj is decimal));

        /// <summary>
        /// Checks if one object of the array is null
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        internal static bool IsOneOfNull(object[] objs) => objs.Any(obj => obj is null);
    }
}