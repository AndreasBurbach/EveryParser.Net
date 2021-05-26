using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EveryParser
{
    internal static class CalculationHelper
    {
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
    }
}