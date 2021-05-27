using Antlr4.Runtime.Misc;
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
        public void EnterMathStatistic_CoVariance([NotNull] EveryGrammarParser.MathStatistic_CoVarianceContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_CoVariance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_CoVariance([NotNull] EveryGrammarParser.MathStatistic_CoVarianceContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Pearson</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Pearson([NotNull] EveryGrammarParser.MathStatistic_PearsonContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Pearson</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Pearson([NotNull] EveryGrammarParser.MathStatistic_PearsonContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Quantil</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Quantil([NotNull] EveryGrammarParser.MathStatistic_QuantilContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Quantil</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Quantil([NotNull] EveryGrammarParser.MathStatistic_QuantilContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Spearman</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Spearman([NotNull] EveryGrammarParser.MathStatistic_SpearmanContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Spearman</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Spearman([NotNull] EveryGrammarParser.MathStatistic_SpearmanContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_StD</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_StD([NotNull] EveryGrammarParser.MathStatistic_StDContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_StD</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_StD([NotNull] EveryGrammarParser.MathStatistic_StDContext context) { }

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
            Node.Value = CalculationHelper.CalcListUnary(context, ErrorCollector, calculation, Node.Children);
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
            Node.Value = CalculationHelper.CalcListUnary(context, ErrorCollector, calculation, Node.Children);
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
            Node.Value = CalculationHelper.CalcListUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }
    }
}