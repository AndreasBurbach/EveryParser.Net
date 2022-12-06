using Antlr4.Runtime;
using EveryParser.LinQReplaces;
using EveryParser.Types;
using System;
using System.Collections.Generic;

namespace EveryParser.GrammarListener.CalculatorListener
{
    public static class CalculationHelper
    {
        /// <summary>
        /// Calculations for Numeric and Numeric Arrays with 1 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcNumericOrNumericArrayUnary(ParserRuleContext context, ErrorCollector errorCollector, Func<object, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return double.NaN;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 1, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
                return double.NaN;

            if (childValues[0] is List<object> list)
                return list.Select(calculationExpression);

            return calculationExpression(childValues[0]);
        }

        /// <summary>
        /// Calculations for Numeric and Numeric Arrays with 2 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcNumericOrNumericArrayBinary(ParserRuleContext context, ErrorCollector errorCollector, Func<object, object, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return double.NaN;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 2, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
                return double.NaN;

            var list1 = childValues[0] as List<object>;
            EPDecimal value1 = 0;
            if (list1 is null)
                value1 = new EPDecimal(childValues[0]);

            var list2 = childValues[1] as List<object>;
            EPDecimal value2 = 0;
            if (list2 is null)
                value2 = new EPDecimal(childValues[1]);

            if (list1 is null && list2 is null)
                return calculationExpression(value1, value2);

            if (!(list1 is null) && list2 is null)
                return list1.Select(x => calculationExpression(x, value2));

            if (list1 is null && !(list2 is null))
                return list2.Select(x => calculationExpression(value1, x));

            if (list1.Count == list2.Count)
            {
                var result = new List<object>(list1.Count);
                for (int i = 0; i < list1.Count; i += 1)
                    result.Add(calculationExpression(list1[i], list2[i]));
                return result;
            }
            else
                errorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {list1.Count} Array2 Count {list2.Count}");

            return double.NaN;
        }

        /// <summary>
        /// Calculations for 2 Boolean childs or 2 childs of List(boolean)
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcBooleanOrBooleanArrayBinary(ParserRuleContext context, ErrorCollector errorCollector, Func<bool, bool, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return null;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 2, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsBooleanOrArrayOfBoolean(context, childValues))
                return null;

            var list1 = childValues[0] as List<object>;
            var list2 = childValues[1] as List<object>;

            if (list1 is null && list2 is null)
                return calculationExpression(Convert.ToBoolean(childValues[0]), Convert.ToBoolean(childValues[1]));

            if ((list1 is null && !(list2 is null)) || (!(list1 is null) && list2 is null))
            {
                errorCollector.AddError(context, ErrorCode.CanBeEitherBooleanOrListBoolean, "Both parameters can be either boolean or List of boolean");
                return null;
            }

            if (list1.Count != list2.Count)
            {
                errorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {list1.Count} Array2 Count {list2.Count}");
                return null;
            }

            var result = new List<object>(list1.Count);
            for (int i = 0; i < list1.Count; i += 1)
                result.Add(calculationExpression(Convert.ToBoolean(list1[i]), Convert.ToBoolean(list2[i])));
            return result;
        }

        /// <summary>
        /// Calculations for List(object) with 1 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcListUnary(ParserRuleContext context, ErrorCollector errorCollector, Func<List<object>, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return null;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 1, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsList(context, childValues))
                return null;

            return calculationExpression((List<object>)childValues[0]);
        }

        /// <summary>
        /// Calculations for List(number) with 1 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcListOfNumbersUnary(ParserRuleContext context, ErrorCollector errorCollector, Func<List<object>, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return null;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 1, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsListOfNumbers(context, childValues))
                return null;

            return calculationExpression((List<object>)childValues[0]);
        }

        /// <summary>
        /// Calculations for List(number) with 2 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcListOfNumbersBinary(ParserRuleContext context, ErrorCollector errorCollector, Func<List<object>, List<object>, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return null;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 2, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsListOfNumbers(context, childValues))
                return null;

            return calculationExpression((List<object>)childValues[0], (List<object>)childValues[0]);
        }

        /// <summary>
        /// Calculations for string or List(object) with 2 childs in Node, but all can only be string or List
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcStringOrListBinary(ParserRuleContext context, ErrorCollector errorCollector, Func<List<object>, List<object>, object> calculationListExpression, Func<string, string, object> calculationStringExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return null;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 2, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsStringOrList(context, childValues))
                return null;

            object value1 = childValues[0];
            object value2 = childValues[1];

            if ((value1 is List<object> && !(value2 is List<object>)) || (!(value1 is List<object>) && value2 is List<object>))
            {
                errorCollector.AddError(context, ErrorCode.CanBeEitherStringOrList, "Both parameters can be either string or List");
                return null;
            }

            if (value1 is List<object> list1 && value2 is List<object> list2)
                return calculationListExpression(list1, list2);

            return calculationStringExpression(value1.ToString(), value2.ToString());
        }

        /// <summary>
        /// Calculations for Numeric with 1 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcNumericUnary(ParserRuleContext context, ErrorCollector errorCollector, Func<object, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return double.NaN;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 1, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsNumber(context, childValues))
                return double.NaN;

            return calculationExpression(childValues[0]);
        }

        /// <summary>
        /// Calculations for Numeric with 2 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcNumericBinary(ParserRuleContext context, ErrorCollector errorCollector, Func<object, object, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return double.NaN;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 2, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsNumber(context, childValues))
                return double.NaN;

            return calculationExpression(childValues[0], childValues[1]);
        }

        /// <summary>
        /// Calculations for Numeric with 3 childs in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcNumericTri(ParserRuleContext context, ErrorCollector errorCollector, Func<object, object, object, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return double.NaN;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 3, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsNumber(context, childValues))
                return double.NaN;

            return calculationExpression(childValues[0], childValues[1], childValues[2]);
        }

        /// <summary>
        /// Calculations for string or List(object) with 1 child in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcStringOrListUnary(ParserRuleContext context, ErrorCollector errorCollector, Func<List<object>, object> calculationListExpression, Func<string, object> calculationStringExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return null;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 1, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsStringOrList(context, childValues))
                return null;

            object value1 = childValues[0];

            if (value1 is List<object> list1)
                return calculationListExpression(list1);

            return calculationStringExpression(value1.ToString());
        }

        /// <summary>
        /// Calculations for string or List(string) with 1 child in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcStringOrStringListUnary(ParserRuleContext context, ErrorCollector errorCollector, Func<string, object> calculationStringExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return null;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 1, childValues) ||
                errorCollector.CheckIsNull(context, childValues) ||
                !errorCollector.CheckIsStringOrListOfStrings(context, childValues))
                return null;

            object value1 = childValues[0];

            if (value1 is List<object> list1)
                return list1.Select(x => calculationStringExpression(x.ToString()));

            return calculationStringExpression(value1.ToString());
        }

        /// <summary>
        /// Calculate the n-th factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long CalcFactorial(int n)
        {
            int count = Math.Abs(n);

            switch (count)
            {
                case 0:
                case 1:
                    return 1;

                case 2:
                    return 2;

                case 3:
                    return 6;

                case 4:
                    return 14;

                case 5:
                    return 120;

                case 6:
                    return 720;

                case 7:
                    return 5040;

                case 8:
                    return 40320;

                case 9:
                    return 362880;

                case 10:
                    return 3628800;
            }

            long val = 1;

            for (int i = 1; i <= count; i += 1)
                val *= i;

            return val;
        }

        /// <summary>
        /// Calculations for any types with 1 child in Node
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorCollector"></param>
        /// <param name="calculationExpression"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        internal static object CalcAnyUnary(ParserRuleContext context, ErrorCollector errorCollector, Func<object, object> calculationExpression, List<NodeCalculator> children)
        {
            if (!errorCollector.CheckHasParams(context, children))
                return null;

            var childValues = children.Select(child => child.Value).ToArray();

            if (!errorCollector.CheckParamsCount(context, 1, childValues) ||
                errorCollector.CheckIsNull(context, childValues))
                return null;

            return calculationExpression(childValues[0]);
        }
    }
}