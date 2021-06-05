using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EveryParser
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
        public void EnterFunction_Duplicates([NotNull] EveryGrammarParser.Function_DuplicatesContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Duplicates</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Duplicates([NotNull] EveryGrammarParser.Function_DuplicatesContext context)
        {
            //War hier gemeint, ob es duplikate im array gibt?
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
            Func<string, object> stringCalculation = x => x.ToLower();
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
            Func<List<object>, object> listCalculation = list => list.Reverse<object>().ToList();
            Func<string, object> stringCalculation = x => new string(x.Reverse().ToList().ConvertAll(y => (char)y).ToArray());
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
            Func<string, object> stringCalculation = x => x.ToUpper();
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
        public void EnterFunction_Any([NotNull] EveryGrammarParser.Function_AnyContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Any</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Any([NotNull] EveryGrammarParser.Function_AnyContext context)
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
    }
}