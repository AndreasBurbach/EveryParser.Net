using Antlr4.Runtime.Misc;
using EveryParser.LinQReplaces;
using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;

namespace EveryParser
{
    public partial class EveryGrammarCalculatorListener
    {
        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_CoVariance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_CoVariance([NotNull] EveryGrammarParser.MathStatistic_CoVarianceContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_CoVariance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_CoVariance([NotNull] EveryGrammarParser.MathStatistic_CoVarianceContext context)
        {
            Func<List<object>, List<object>, object> calculation = (list1, list2) => (object)ArrayStatistics.Covariance(Array.ConvertAll(list1.ToArray(), x => Convert.ToDouble(x)), Array.ConvertAll(list2.ToArray(), x => Convert.ToDouble(x)));
            Node.Value = CalculationHelper.CalcListOfNumbersBinary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Pearson</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Pearson([NotNull] EveryGrammarParser.MathStatistic_PearsonContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Pearson</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Pearson([NotNull] EveryGrammarParser.MathStatistic_PearsonContext context)
        {
            Func<List<object>, List<object>, object> calculation = (list1, list2) => (object)Correlation.Pearson(Array.ConvertAll(list1.ToArray(), x => Convert.ToDouble(x)), Array.ConvertAll(list2.ToArray(), x => Convert.ToDouble(x)));
            Node.Value = CalculationHelper.CalcListOfNumbersBinary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Quantil</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Quantil([NotNull] EveryGrammarParser.MathStatistic_QuantilContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Quantil</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Quantil([NotNull] EveryGrammarParser.MathStatistic_QuantilContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 2, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues) ||
                !ErrorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            var list = childValues[0] as List<object>;

            if (list is null)
            {
                ErrorCollector.AddError(context, ErrorCode.FirstNotNumberArray, "First parameter must be an Array");
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            if (!double.TryParse(childValues[1].ToString(), out var value))
            {
                ErrorCollector.AddError(context, ErrorCode.SecondNotNumber, "Second parameter must be a number");
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            Node.Value = ArrayStatistics.QuantileInplace(list.ConvertAll(x => Convert.ToDouble(x)).ToArray(), value);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Spearman</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Spearman([NotNull] EveryGrammarParser.MathStatistic_SpearmanContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Spearman</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Spearman([NotNull] EveryGrammarParser.MathStatistic_SpearmanContext context)
        {
            Func<List<object>, List<object>, object> calculation = (list1, list2) => (object)Correlation.Spearman(Array.ConvertAll(list1.ToArray(), x => Convert.ToDouble(x)), Array.ConvertAll(list2.ToArray(), x => Convert.ToDouble(x)));
            Node.Value = CalculationHelper.CalcListOfNumbersBinary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_StD</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_StD([NotNull] EveryGrammarParser.MathStatistic_StDContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_StD</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_StD([NotNull] EveryGrammarParser.MathStatistic_StDContext context)
        {
            Func<List<object>, object> calculation = list => (object)ArrayStatistics.StandardDeviation(Array.ConvertAll(list.ToArray(), x => Convert.ToDouble(x)));
            Node.Value = CalculationHelper.CalcListOfNumbersUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Mean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Mean([NotNull] EveryGrammarParser.MathStatistic_MeanContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Mean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Mean([NotNull] EveryGrammarParser.MathStatistic_MeanContext context)
        {
            Func<List<object>, object> calculation = list => (object)ArrayStatistics.Mean(Array.ConvertAll(list.ToArray(), x => Convert.ToDouble(x)));
            Node.Value = CalculationHelper.CalcListOfNumbersUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Median</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Median([NotNull] EveryGrammarParser.MathStatistic_MedianContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Median</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Median([NotNull] EveryGrammarParser.MathStatistic_MedianContext context)
        {
            Func<List<object>, object> calculation = list => (object)ArrayStatistics.MedianInplace(Array.ConvertAll(list.ToArray(), x => Convert.ToDouble(x)));
            Node.Value = CalculationHelper.CalcListOfNumbersUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Variance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Variance([NotNull] EveryGrammarParser.MathStatistic_VarianceContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Variance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Variance([NotNull] EveryGrammarParser.MathStatistic_VarianceContext context)
        {
            Func<List<object>, object> calculation = list => (object)ArrayStatistics.Variance(Array.ConvertAll(list.ToArray(), x => Convert.ToDouble(x)));
            Node.Value = CalculationHelper.CalcListOfNumbersUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }
    }
}