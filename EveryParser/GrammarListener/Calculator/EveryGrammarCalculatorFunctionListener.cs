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
        public void ExitFunction_Concat([NotNull] EveryGrammarParser.Function_ConcatContext context) { }

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
        public void ExitFunction_Count([NotNull] EveryGrammarParser.Function_CountContext context) { }

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
            Func<List<object>, object> calculation = list => list.Distinct().ToList();
            Node.Value = CalculationHelper.CalcListUnary(context, ErrorCollector, calculation, Node.Children);
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
        public void ExitFunction_IndexOf([NotNull] EveryGrammarParser.Function_IndexOfContext context) { }

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
            Node = Node.AddChildNode();
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
            Func<List<object>, object> calculation = list => list.Reverse<object>().ToList();
            Node.Value = CalculationHelper.CalcListUnary(context, ErrorCollector, calculation, Node.Children);
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
        public void ExitFunction_Upper([NotNull] EveryGrammarParser.Function_UpperContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Difference</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Difference([NotNull] EveryGrammarParser.Function_DifferenceContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Difference</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Difference([NotNull] EveryGrammarParser.Function_DifferenceContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Except</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Except([NotNull] EveryGrammarParser.Function_ExceptContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Except</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Except([NotNull] EveryGrammarParser.Function_ExceptContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Any</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Any([NotNull] EveryGrammarParser.Function_AnyContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Any</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Any([NotNull] EveryGrammarParser.Function_AnyContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Sort</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Sort([NotNull] EveryGrammarParser.Function_SortContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Sort</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Sort([NotNull] EveryGrammarParser.Function_SortContext context) { }
    }
}