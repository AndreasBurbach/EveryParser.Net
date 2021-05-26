using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EveryParser
{
    internal static class CalculationHelper
    {
        /// <summary>
        /// Calculations for Numeric and Numeric Arrays with 1 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcNumericOrNumericArrayUnary(ParserRuleContext context, AssertErrors errorCollector, Func<object, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return double.NaN;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 1, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
                return double.NaN;

            if (childValues[0] is List<object> list)
                return list.Select(calculationExpression).ToList();

            return calculationExpression.Invoke(childValues[0]);
        }

        /// <summary>
        /// Calculations for Numeric and Numeric Arrays with 2 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <param name="secondChildIsInconsitent">if second child can be an array of numbers or a number, without thinking of the first child type. Example: Math.Pow(... , ...) should be true.</param>
        /// <returns></returns>
        internal static object CalcNumericOrNumericArrayBinary(ParserRuleContext context, AssertErrors errorCollector, Func<object, object, object> calculationExpression, List<NodeCalculator> children, bool secondChildIsInconsitent = false)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return double.NaN;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 2, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
                return double.NaN;

            var list1 = childValues[0] as List<object>;
            decimal value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDecimal(childValues[0]);

            var list2 = childValues[1] as List<object>;
            decimal value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDecimal(childValues[1]);

            if (list1 is null && list2 is null)
                return calculationExpression.Invoke(value1, value2);

            if (secondChildIsInconsitent)
            {
                if (!(list1 is null))
                {
                    if (list2 is null)
                        return list1.Select(x => calculationExpression(x, value2)).ToList();
                    else if (list1.Count == list2.Count)
                    {
                        var result = new List<object>(list1.Count);
                        for (int i = 0; i < list1.Count; i += 1)
                            result.Add(calculationExpression.Invoke(list1[i], list2[i]));
                        return result;
                    }
                    else
                        errorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {list1.Count} Array2 Count {list2.Count}");
                }
                else
                    errorCollector.AddError(context, ErrorCode.NotEqualArayCount, "If second parameter is an array, all parameters must be an array");
            }
            else
            {
                if (!(list1 is null) && list2 is null)
                    return list1.Select(x => calculationExpression(x, value2)).ToList();
                else if (list1 is null && !(list2 is null))
                    return list2.Select(x => calculationExpression(x, value1)).ToList();
                else if (list1.Count == list2.Count)
                {
                    var result = new List<object>(list1.Count);
                    for (int i = 0; i < list1.Count; i += 1)
                        result.Add(calculationExpression.Invoke(list1[i], list2[i]));
                    return result;
                }
                else
                    errorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {list1.Count} Array2 Count {list2.Count}");
            }
            return double.NaN;
        }
    }
}