using Antlr4.Runtime.Misc;
using EveryParser.LinQReplaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace EveryParser.GrammarListener.CalculatorListener
{
    public partial class EveryGrammarCalculatorListener
    {
        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Concat</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Concat([NotNull] EveryGrammarParser.Function_ConcatContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Concat</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Concat([NotNull] EveryGrammarParser.Function_ConcatContext context)
        {
            Func<string, string, object> stringCalculation = (x, y) => x + y;
            Func<List<object>, List<object>, object> listCalculation = (x, y) =>
            {
                var result = new List<object>(x.Count + y.Count);
                result.AddRange(x);
                result.AddRange(y);
                return result;
            };

            Node.Value = CalculationHelper.CalcStringOrListBinary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Count</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Count([NotNull] EveryGrammarParser.Function_CountContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Count</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Count([NotNull] EveryGrammarParser.Function_CountContext context)
        {
            Func<List<object>, object> listCalculation = x => x.Count;
            Func<string, object> stringCalculation = x => x.Length;

            Node.Value = CalculationHelper.CalcStringOrListUnary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Distinc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Distinc([NotNull] EveryGrammarParser.Function_DistincContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Distinc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Distinc([NotNull] EveryGrammarParser.Function_DistincContext context)
        {
            Func<List<object>, object> listCalculation = list => list.Distinct().ToList();
            Func<string, object> stringCalculation = x => new string(x.Distinct().ToList().ConvertAll(y => (char)y).ToArray());
            Node.Value = CalculationHelper.CalcStringOrListUnary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Duplicates</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_HasDuplicates([NotNull] EveryGrammarParser.CheckFunction_HasDuplicatesContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Duplicates</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_HasDuplicates([NotNull] EveryGrammarParser.CheckFunction_HasDuplicatesContext context)
        {
            Func<List<object>, object> listCalculation = list => list.Distinct().Count() < list.Count;
            Func<string, object> stringCalculation = x => x.Distinct().Count() < x.Length;
            Node.Value = CalculationHelper.CalcStringOrListUnary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_IndexOf</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_IndexOf([NotNull] EveryGrammarParser.Function_IndexOfContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_IndexOf</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_IndexOf([NotNull] EveryGrammarParser.Function_IndexOfContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 2, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            List<object> list = childValues[0] as List<object>;
            object value2 = childValues[1];

            if (list is null)
                list = childValues[0].ToString().ToList().ConvertAll(x => (object)x);

            Node.Value = list.IndexOf(value2);

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_IndexOfStart</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_IndexOfStart([NotNull] EveryGrammarParser.Function_IndexOfStartContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_IndexOfStart</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_IndexOfStart([NotNull] EveryGrammarParser.Function_IndexOfStartContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 3, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            List<object> list = childValues[0] as List<object>;
            object value2 = childValues[1];
            object value3 = childValues[2];

            if (!int.TryParse(value3.ToString(), out int startIndex))
            {
                ErrorCollector.AddError(context, ErrorCode.ThridNotNumber, "Third parameter must be a number");
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            if (list is null)
                list = childValues[0].ToString().ToList().ConvertAll(x => (object)x);

            Node.Value = list.IndexOf(value2, startIndex);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_IndexOfStartEnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_IndexOfStartEnd([NotNull] EveryGrammarParser.Function_IndexOfStartEndContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_IndexOfStartEnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_IndexOfStartEnd([NotNull] EveryGrammarParser.Function_IndexOfStartEndContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 4, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            List<object> list = childValues[0] as List<object>;
            object value2 = childValues[1];

            if (!int.TryParse(childValues[2].ToString(), out int startIndex))
            {
                ErrorCollector.AddError(context, ErrorCode.ThridNotNumber, "Third parameter must be a number");
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            if (!int.TryParse(childValues[3].ToString(), out int endIndex))
            {
                ErrorCollector.AddError(context, ErrorCode.ForthNotNumber, "Forth parameter must be a number");
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            if (list is null)
                list = childValues[0].ToString().ToList().ConvertAll(x => (object)x);

            Node.Value = list.IndexOf(value2, startIndex, endIndex);

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Lower([NotNull] EveryGrammarParser.Function_LowerContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Lower([NotNull] EveryGrammarParser.Function_LowerContext context)
        {
            Func<string, object> stringCalculation = x => x.ToLower(CultureInfo.InvariantCulture);
            Node.Value = CalculationHelper.CalcStringOrStringListUnary(context, ErrorCollector, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Reverse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Reverse([NotNull] EveryGrammarParser.Function_ReverseContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Reverse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Reverse([NotNull] EveryGrammarParser.Function_ReverseContext context)
        {
            Func<List<object>, object> listCalculation = list => list.ToReverse();
            Func<string, object> stringCalculation = x => x.ToReverse();
            Node.Value = CalculationHelper.CalcStringOrListUnary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Upper</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Upper([NotNull] EveryGrammarParser.Function_UpperContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Upper</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Upper([NotNull] EveryGrammarParser.Function_UpperContext context)
        {
            Func<string, object> stringCalculation = x => x.ToUpper(CultureInfo.InvariantCulture);
            Node.Value = CalculationHelper.CalcStringOrStringListUnary(context, ErrorCollector, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Difference</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Difference([NotNull] EveryGrammarParser.Function_DifferenceContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Difference</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Difference([NotNull] EveryGrammarParser.Function_DifferenceContext context)
        {
            Func<List<object>, List<object>, object> listCalculation = (x, y) =>
            {
                var xWithoutY = x.Except(y);
                var yWithoutX = y.Except(x);
                var uv = new List<object>(xWithoutY);
                uv.AddRange(yWithoutX);

                return uv;
            };
            Func<string, string, object> stringCalculation = (x, y) =>
            {
                var diff = listCalculation(Array.ConvertAll(x.ToArray(), u => (object)u).ToList(), Array.ConvertAll(x.ToArray(), u => (object)u).ToList());
                if (diff is List<object> list)
                    return new string(list.ConvertAll(v => (char)v).ToArray());

                return null;
            };

            Node.Value = CalculationHelper.CalcStringOrListBinary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Except</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Except([NotNull] EveryGrammarParser.Function_ExceptContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Except</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Except([NotNull] EveryGrammarParser.Function_ExceptContext context)
        {
            Func<List<object>, List<object>, object> listCalculation = (x, y) => x.Except(y).ToList();
            Func<string, string, object> stringCalculation = (x, y) => new string(x.Except(y).ToList().ConvertAll(v => (char)v).ToArray());

            Node.Value = CalculationHelper.CalcStringOrListBinary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Any</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_HasAny([NotNull] EveryGrammarParser.CheckFunction_HasAnyContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Any</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_HasAny([NotNull] EveryGrammarParser.CheckFunction_HasAnyContext context)
        {
            Func<List<object>, object> listCalculation = list => list.Any();
            Func<string, object> stringCalculation = x => x.Any();
            Node.Value = CalculationHelper.CalcStringOrListUnary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Sort</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Sort([NotNull] EveryGrammarParser.Function_SortContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Sort</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Sort([NotNull] EveryGrammarParser.Function_SortContext context)
        {
            Func<List<object>, object> listCalculation = list =>
            {
                var result = new List<object>(list);
                result.Sort();
                return result;
            };
            Func<string, object> stringCalculation = x =>
            {
                var result = x.ToList();
                result.Sort();
                return new string(result.ToArray());
            };
            Node.Value = CalculationHelper.CalcStringOrListUnary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsArray([NotNull] EveryGrammarParser.CheckFunction_IsArrayContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsArray([NotNull] EveryGrammarParser.CheckFunction_IsArrayContext context)
        {
            Func<object, object> calculation = x => x is List<object>;
            Node.Value = CalculationHelper.CalcAnyUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsBoolean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsBoolean([NotNull] EveryGrammarParser.CheckFunction_IsBooleanContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsBoolean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsBoolean([NotNull] EveryGrammarParser.CheckFunction_IsBooleanContext context)
        {
            Func<object, object> calculation = x => TypeCheckHelper.IsBoolean(x);
            Node.Value = CalculationHelper.CalcAnyUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsDateTime</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsDateTime([NotNull] EveryGrammarParser.CheckFunction_IsDateTimeContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsDateTime</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsDateTime([NotNull] EveryGrammarParser.CheckFunction_IsDateTimeContext context)
        {
            Func<object, object> calculation = x => x is DateTime;
            Node.Value = CalculationHelper.CalcAnyUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsNull</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsNull([NotNull] EveryGrammarParser.CheckFunction_IsNullContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsNull</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsNull([NotNull] EveryGrammarParser.CheckFunction_IsNullContext context)
        {
            Func<object, object> calculation = x => x is null;
            Node.Value = CalculationHelper.CalcAnyUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsNumber</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsNumber([NotNull] EveryGrammarParser.CheckFunction_IsNumberContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsNumber</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsNumber([NotNull] EveryGrammarParser.CheckFunction_IsNumberContext context)
        {
            Func<object, object> calculation = x => TypeCheckHelper.IsNumber(x);
            Node.Value = CalculationHelper.CalcAnyUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsString</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsString([NotNull] EveryGrammarParser.CheckFunction_IsStringContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsString</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsString([NotNull] EveryGrammarParser.CheckFunction_IsStringContext context)
        {
            Func<object, object> calculation = x => x is string;
            Node.Value = CalculationHelper.CalcAnyUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsWhitespace</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsWhitespace([NotNull] EveryGrammarParser.CheckFunction_IsWhitespaceContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsWhitespace</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsWhitespace([NotNull] EveryGrammarParser.CheckFunction_IsWhitespaceContext context)
        {
            Func<string, object> stringCalculation = x => !(x is null) && string.IsNullOrWhiteSpace(x);
            Node.Value = CalculationHelper.CalcStringOrStringListUnary(context, ErrorCollector, stringCalculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Trim</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Trim([NotNull] EveryGrammarParser.Function_TrimContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Trim</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Trim([NotNull] EveryGrammarParser.Function_TrimContext context)
        {
            Func<List<object>, object> listCalculation = list =>
            {
                int i = 0;
                for (; i < list.Count; i += 1)
                {
                    var obj = list[i];
                    if (obj is null || (obj is string sValue && string.IsNullOrWhiteSpace(sValue)))
                        continue;

                    break;
                }

                int k = list.Count - 1;
                for (; k > -1; k -= 1)
                {
                    var obj = list[k];
                    if (obj is null || (obj is string sValue && string.IsNullOrWhiteSpace(sValue)))
                        continue;
                    break;
                }

                if (i == list.Count || k == -1)
                    return new List<object>();

                k += 1;

                return list.GetRange(i, k - i);
            };
            Func<string, object> stringCalculation = x => x.Trim();
            Node.Value = CalculationHelper.CalcStringOrListUnary(context, ErrorCollector, listCalculation, stringCalculation, Node.Children);
            Node = Node.Parent;
        }
    }
}