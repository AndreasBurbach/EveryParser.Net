using Antlr4.Runtime.Misc;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

namespace EveryParser
{
    /// <summary>
    /// This class provides an empty implementation of <see cref="IEveryGrammarListener"/>,
    /// which can be extended to create a listener which only needs to handle a subset
    /// of the available methods.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
    public class EveryGrammarBaseListener : IEveryGrammarListener
    {
        internal NodeCalculator Node;
        public AssertErrors ErrorCollector;
        public object Result = null;
        public SortedList<string, object> Arguments;

        /// <summary>
        /// Enter a parse tree produced by <see cref="EveryGrammarParser.startRule"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterStartRule([NotNull] EveryGrammarParser.StartRuleContext context)
        {
            Node = new NodeCalculator();
            ErrorCollector = new AssertErrors();
            Result = null;
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="EveryGrammarParser.startRule"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitStartRule([NotNull] EveryGrammarParser.StartRuleContext context)
        {
            if (ErrorCollector.CheckHasParams(context, Node.Children))
                Result = Node.Children[0].Value;
            else
                Result = null;
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="EveryGrammarParser.expression"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterExpression([NotNull] EveryGrammarParser.ExpressionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by <see cref="EveryGrammarParser.expression"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitExpression([NotNull] EveryGrammarParser.ExpressionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>IfElse_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterIfElse_Next([NotNull] EveryGrammarParser.IfElse_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>IfElse_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitIfElse_Next([NotNull] EveryGrammarParser.IfElse_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing([NotNull] EveryGrammarParser.ArraySlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing([NotNull] EveryGrammarParser.ArraySlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>IfElse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterIfElse([NotNull] EveryGrammarParser.IfElseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>IfElse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitIfElse([NotNull] EveryGrammarParser.IfElseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>InnerIfElse_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.inner_if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterInnerIfElse_Next([NotNull] EveryGrammarParser.InnerIfElse_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>InnerIfElse_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.inner_if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitInnerIfElse_Next([NotNull] EveryGrammarParser.InnerIfElse_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>InnerIfElse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.inner_if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterInnerIfElse([NotNull] EveryGrammarParser.InnerIfElseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>InnerIfElse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.inner_if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitInnerIfElse([NotNull] EveryGrammarParser.InnerIfElseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolOr_Next([NotNull] EveryGrammarParser.BoolOr_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolOr_Next([NotNull] EveryGrammarParser.BoolOr_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolOr([NotNull] EveryGrammarParser.BoolOrContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolOr([NotNull] EveryGrammarParser.BoolOrContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolAnd_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolAnd_Next([NotNull] EveryGrammarParser.BoolAnd_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolAnd_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolAnd_Next([NotNull] EveryGrammarParser.BoolAnd_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolAnd([NotNull] EveryGrammarParser.BoolAndContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolAnd([NotNull] EveryGrammarParser.BoolAndContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_Contains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_Contains([NotNull] EveryGrammarParser.Equality_ContainsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_Contains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_Contains([NotNull] EveryGrammarParser.Equality_ContainsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_Next([NotNull] EveryGrammarParser.Equality_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_Next([NotNull] EveryGrammarParser.Equality_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_Equal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_Equal([NotNull] EveryGrammarParser.Equality_EqualContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_Equal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_Equal([NotNull] EveryGrammarParser.Equality_EqualContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_NotEqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_NotEqualIgnoreCase([NotNull] EveryGrammarParser.Equality_NotEqualIgnoreCaseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_NotEqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_NotEqualIgnoreCase([NotNull] EveryGrammarParser.Equality_NotEqualIgnoreCaseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_NotEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_NotEqual([NotNull] EveryGrammarParser.Equality_NotEqualContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_NotEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_NotEqual([NotNull] EveryGrammarParser.Equality_NotEqualContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_NotContains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_NotContains([NotNull] EveryGrammarParser.Equality_NotContainsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_NotContains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_NotContains([NotNull] EveryGrammarParser.Equality_NotContainsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_EqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_EqualIgnoreCase([NotNull] EveryGrammarParser.Equality_EqualIgnoreCaseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_EqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_EqualIgnoreCase([NotNull] EveryGrammarParser.Equality_EqualIgnoreCaseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_Next([NotNull] EveryGrammarParser.Check_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_Next([NotNull] EveryGrammarParser.Check_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_Greater</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_Greater([NotNull] EveryGrammarParser.Check_GreaterContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_Greater</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_Greater([NotNull] EveryGrammarParser.Check_GreaterContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_GreaterEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_GreaterEqual([NotNull] EveryGrammarParser.Check_GreaterEqualContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_GreaterEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_GreaterEqual([NotNull] EveryGrammarParser.Check_GreaterEqualContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_Lower([NotNull] EveryGrammarParser.Check_LowerContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_Lower([NotNull] EveryGrammarParser.Check_LowerContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_LowerEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_LowerEqual([NotNull] EveryGrammarParser.Check_LowerEqualContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_LowerEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_LowerEqual([NotNull] EveryGrammarParser.Check_LowerEqualContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitOR</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitOR([NotNull] EveryGrammarParser.BitORContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitOR</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitOR([NotNull] EveryGrammarParser.BitORContext context)
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
                !ErrorCollector.CheckIsNumber(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            Node.Value = Convert.ToInt64(childValues[0]) | Convert.ToInt64(childValues[1]);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitOr_Next([NotNull] EveryGrammarParser.BitOr_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitOr_Next([NotNull] EveryGrammarParser.BitOr_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitAnd([NotNull] EveryGrammarParser.BitAndContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitAnd([NotNull] EveryGrammarParser.BitAndContext context)
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
                !ErrorCollector.CheckIsNumber(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            Node.Value = Convert.ToInt64(childValues[0]) & Convert.ToInt64(childValues[1]);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitAnd_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitAnd_Next([NotNull] EveryGrammarParser.BitAnd_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitAnd_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitAnd_Next([NotNull] EveryGrammarParser.BitAnd_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Line_Addition</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterLine_Addition([NotNull] EveryGrammarParser.Line_AdditionContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Line_Addition</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitLine_Addition([NotNull] EveryGrammarParser.Line_AdditionContext context)
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

            var list1 = childValues[0] as List<object>;
            decimal value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDecimal(childValues[0]);

            var list2 = childValues[1] as List<object>;
            decimal value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDecimal(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = value1 + value2;
            }
            else if (!(list1 is null) && list2 is null)
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                Node.Value = (vector1 + value2).Select(x => (object)x).ToList();
            }
            else if (list1 is null && !(list2 is null))
            {
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = (value1 + vector2).Select(x => (object)x).ToList();
            }
            else
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = (vector1 + vector2).Select(x => (object)x).ToList();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Line_Subtraction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterLine_Subtraction([NotNull] EveryGrammarParser.Line_SubtractionContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Line_Subtraction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitLine_Subtraction([NotNull] EveryGrammarParser.Line_SubtractionContext context)
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

            var list1 = childValues[0] as List<object>;
            decimal value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDecimal(childValues[0]);

            var list2 = childValues[1] as List<object>;
            decimal value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDecimal(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = value1 - value2;
            }
            else if (!(list1 is null) && list2 is null)
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                Node.Value = (vector1 - value2).Select(x => (object)x).ToList();
            }
            else if (list1 is null && !(list2 is null))
            {
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = (value1 - vector2).Select(x => (object)x).ToList();
            }
            else
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = (vector1 - vector2).Select(x => (object)x).ToList();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Line_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterLine_Next([NotNull] EveryGrammarParser.Line_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Line_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitLine_Next([NotNull] EveryGrammarParser.Line_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Factor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Factor([NotNull] EveryGrammarParser.PointTerm_FactorContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Factor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Factor([NotNull] EveryGrammarParser.PointTerm_FactorContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Modulo</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Modulo([NotNull] EveryGrammarParser.PointTerm_ModuloContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Modulo</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Modulo([NotNull] EveryGrammarParser.PointTerm_ModuloContext context)
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

            var list1 = childValues[0] as List<object>;
            decimal value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDecimal(childValues[0]);

            var list2 = childValues[1] as List<object>;
            decimal value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDecimal(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = value1 % value2;
            }
            else if (!(list1 is null) && list2 is null)
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                Node.Value = (vector1 % value2).Select(x => (object)x).ToList();
            }
            else if (list1 is null && !(list2 is null))
            {
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = (value1 % vector2).Select(x => (object)x).ToList();
            }
            else
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = (vector1 % vector2).Select(x => (object)x).ToList();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Multiply</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Multiply([NotNull] EveryGrammarParser.PointTerm_MultiplyContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Multiply</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Multiply([NotNull] EveryGrammarParser.PointTerm_MultiplyContext context)
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

            var list1 = childValues[0] as List<object>;
            decimal value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDecimal(childValues[0]);

            var list2 = childValues[1] as List<object>;
            decimal value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDecimal(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = value1 * value2;
            }
            else if (!(list1 is null) && list2 is null)
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                Node.Value = (vector1 * value2).Select(x => (object)x).ToList();
            }
            else if (list1 is null && !(list2 is null))
            {
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = (value1 * vector2).Select(x => (object)x).ToList();
            }
            else
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = vector1 * vector2;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_BitShiftLeft</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_BitShiftLeft([NotNull] EveryGrammarParser.PointTerm_BitShiftLeftContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_BitShiftLeft</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_BitShiftLeft([NotNull] EveryGrammarParser.PointTerm_BitShiftLeftContext context)
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
                !ErrorCollector.CheckIsNumber(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            Node.Value = Convert.ToInt64(childValues[0]) << Convert.ToInt32(childValues[1]);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_IntegerDivision</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_IntegerDivision([NotNull] EveryGrammarParser.PointTerm_IntegerDivisionContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_IntegerDivision</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_IntegerDivision([NotNull] EveryGrammarParser.PointTerm_IntegerDivisionContext context)
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

            var list1 = childValues[0] as List<object>;
            long value1 = 0;
            if (list1 is null)
                value1 = Convert.ToInt64(childValues[0]);

            var list2 = childValues[1] as List<object>;
            long value2 = 0;
            if (list2 is null)
                value2 = Convert.ToInt64(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = value1 / value2;
            }
            else if (!(list1 is null) && list2 is null)
            {
                var vector1 = Vector<long>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToInt64(x)));
                Node.Value = (vector1 / value2).Select(x => (object)x).ToList();
            }
            else if (list1 is null && !(list2 is null))
            {
                var vector2 = Vector<long>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToInt64(x)));
                Node.Value = (value1 / vector2).Select(x => (object)x).ToList();
            }
            else
            {
                var vector1 = Vector<long>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToInt64(x)));
                var vector2 = Vector<long>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToInt64(x)));
                Node.Value = (vector1 / vector2).Select(x => (object)x).ToList();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_BitShiftRight</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_BitShiftRight([NotNull] EveryGrammarParser.PointTerm_BitShiftRightContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_BitShiftRight</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_BitShiftRight([NotNull] EveryGrammarParser.PointTerm_BitShiftRightContext context)
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
                !ErrorCollector.CheckIsNumber(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            Node.Value = Convert.ToInt64(childValues[0]) >> Convert.ToInt32(childValues[1]);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Divide</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Divide([NotNull] EveryGrammarParser.PointTerm_DivideContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Divide</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Divide([NotNull] EveryGrammarParser.PointTerm_DivideContext context)
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

            var list1 = childValues[0] as List<object>;
            decimal value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDecimal(childValues[0]);

            var list2 = childValues[1] as List<object>;
            decimal value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDecimal(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = value1 / value2;
            }
            else if (!(list1 is null) && list2 is null)
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                Node.Value = (vector1 / value2).Select(x => (object)x).ToList();
            }
            else if (list1 is null && !(list2 is null))
            {
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = (value1 / vector2).Select(x => (object)x).ToList();
            }
            else
            {
                var vector1 = Vector<decimal>.Build.DenseOfEnumerable(list1.Select(x => Convert.ToDecimal(x)));
                var vector2 = Vector<decimal>.Build.DenseOfEnumerable(list2.Select(x => Convert.ToDecimal(x)));
                Node.Value = (vector1 / vector2).Select(x => (object)x).ToList();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Not</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Not([NotNull] EveryGrammarParser.Factor_NotContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Not</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Not([NotNull] EveryGrammarParser.Factor_NotContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Minus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Minus([NotNull] EveryGrammarParser.Factor_MinusContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Minus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Minus([NotNull] EveryGrammarParser.Factor_MinusContext context)
        {
            Func<object, object> calculation = x => (object)-Convert.ToDecimal(x);
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Plus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Plus([NotNull] EveryGrammarParser.Factor_PlusContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Plus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Plus([NotNull] EveryGrammarParser.Factor_PlusContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 1, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues) ||
                !ErrorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            Node.Value = childValues[0];
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Tilde</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Tilde([NotNull] EveryGrammarParser.Factor_TildeContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Tilde</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Tilde([NotNull] EveryGrammarParser.Factor_TildeContext context)
        {
            Func<object, object> calculation = x => (object)~Convert.ToInt64(x);
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Brackets</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Brackets([NotNull] EveryGrammarParser.Factor_BracketsContext context)
        {
            //    var childNode = Node.AddChildNode();
            //    Node = childNode;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Brackets</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Brackets([NotNull] EveryGrammarParser.Factor_BracketsContext context)
        {
            //if (ErrorCollector.CheckHasParams(context, Node.Children))
            //    Node.Value = Node.Children[0].Value;
            //else
            //    Result = null;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_True</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_True([NotNull] EveryGrammarParser.Factor_TrueContext context)
        {
            Node.AddChildNode(true);
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_True</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_True([NotNull] EveryGrammarParser.Factor_TrueContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_False</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_False([NotNull] EveryGrammarParser.Factor_FalseContext context)
        {
            Node.AddChildNode(false);
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_False</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_False([NotNull] EveryGrammarParser.Factor_FalseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Integer([NotNull] EveryGrammarParser.Factor_IntegerContext context)
        {
            string text = context.GetText();
            if (long.TryParse(text, out long value))
                Node.AddChildNode(value);
            else
            {
                ErrorCollector.AddTypeConversionError(context, text, typeof(long));
                Node.AddChildNode(double.NaN);
            }
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Integer([NotNull] EveryGrammarParser.Factor_IntegerContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Double</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Double([NotNull] EveryGrammarParser.Factor_DoubleContext context)
        {
            string text = context.GetText();
            if (decimal.TryParse(text, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out decimal value))
                Node.AddChildNode(value);
            else
            {
                ErrorCollector.AddTypeConversionError(context, text, typeof(decimal));
                Node.AddChildNode(double.NaN);
            }
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Double</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Double([NotNull] EveryGrammarParser.Factor_DoubleContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Variable</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Variable([NotNull] EveryGrammarParser.Factor_VariableContext context)
        {
            string text = context.GetText();
            if (text.Equals("e", StringComparison.InvariantCultureIgnoreCase))
            {
                Node.AddChildNode(2.71828182845904523536028747135266249775724709369995957496696762772407663035354759457138217852516642742746m);
                return;
            }
            else if (text.Equals("pi", StringComparison.InvariantCultureIgnoreCase))
            {
                Node.AddChildNode(3.14159265358979323846264338327950288419716939937510582097494459230781640628620899862803482534211706798214m);
                return;
            }
            else if (text.Equals("date_now", StringComparison.InvariantCultureIgnoreCase))
            {
                Node.AddChildNode(DateTime.Now);
                return;
            }

            Node.AddChildNode(ErrorCollector.GetCheckedArgument(context, Arguments, text));
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Variable</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Variable([NotNull] EveryGrammarParser.Factor_VariableContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_ObjectVariables</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_ObjectVariables([NotNull] EveryGrammarParser.Factor_ObjectVariablesContext context)
        {
            string text = context.GetText();
            Node.AddChildNode(ErrorCollector.GetCheckedObjectArgument(context, Arguments, text));
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_ObjectVariables</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_ObjectVariables([NotNull] EveryGrammarParser.Factor_ObjectVariablesContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_String</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_String([NotNull] EveryGrammarParser.Factor_StringContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_String</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_String([NotNull] EveryGrammarParser.Factor_StringContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_DateTimeTerm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_DateTimeTerm([NotNull] EveryGrammarParser.Factor_DateTimeTermContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_DateTimeTerm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_DateTimeTerm([NotNull] EveryGrammarParser.Factor_DateTimeTermContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();
            var childValuesLength = childValues.Length;

            if (!ErrorCollector.CheckParamsCountGreaterEqual(context, 1, childValues) ||
                !ErrorCollector.CheckParamsCountLowerEqual(context, 7, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues) ||
                !ErrorCollector.CheckIsNumber(context, childValues)
                )
            {
                SetErrorNodeFor_ExitFactor_DateTimeTerm();
                return;
            }

            var date = new DateTime();
            for (var datePartIndex = 0; datePartIndex < childValuesLength; datePartIndex++)
            {
                var datePartChildString = childValues[datePartIndex].ToString();
                if (!int.TryParse(datePartChildString, out var datePart))
                {
                    ErrorCollector.AddTypeConversionError(context, datePartChildString, typeof(int));
                    SetErrorNodeFor_ExitFactor_DateTimeTerm();
                    return;
                }

                switch (datePartIndex)
                {
                    case 0:
                        date = date.AddYears(datePart - date.Year);
                        break;

                    case 1:
                        date = date.AddMonths(datePart - date.Month);
                        break;

                    case 2:
                        date = date.AddDays(datePart - date.Day);
                        break;

                    case 3:
                        date = date.AddHours(datePart - date.Hour);
                        break;

                    case 4:
                        date = date.AddMinutes(datePart - date.Minute);
                        break;

                    case 5:
                        date = date.AddSeconds(datePart - date.Second);
                        break;

                    case 6:
                        date = date.AddMilliseconds(datePart - date.Millisecond);
                        break;
                }
            }

            Node.Value = date;
            Node = Node.Parent;
        }

        private void SetErrorNodeFor_ExitFactor_DateTimeTerm()
        {
            Node.Value = double.NaN;
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Array([NotNull] EveryGrammarParser.Factor_ArrayContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Array([NotNull] EveryGrammarParser.Factor_ArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_DefaultFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_DefaultFunction([NotNull] EveryGrammarParser.Factor_DefaultFunctionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_DefaultFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_DefaultFunction([NotNull] EveryGrammarParser.Factor_DefaultFunctionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_MathFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_MathFunction([NotNull] EveryGrammarParser.Factor_MathFunctionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_MathFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_MathFunction([NotNull] EveryGrammarParser.Factor_MathFunctionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_StatisticMathFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_StatisticMathFunction([NotNull] EveryGrammarParser.Factor_StatisticMathFunctionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_StatisticMathFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_StatisticMathFunction([NotNull] EveryGrammarParser.Factor_StatisticMathFunctionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_Expression</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_Expression([NotNull] EveryGrammarParser.DateTime_ExpressionContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_Expression</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_Expression([NotNull] EveryGrammarParser.DateTime_ExpressionContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 1, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues) ||
                !ErrorCollector.CheckIsNumber(context, childValues))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            Node.Value = Convert.ToInt32(childValues[0]);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateEntry</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateEntry([NotNull] EveryGrammarParser.DateTime_DateEntryContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateEntry</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateEntry([NotNull] EveryGrammarParser.DateTime_DateEntryContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateHour</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateHour([NotNull] EveryGrammarParser.DateTime_DateHourContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateHour</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateHour([NotNull] EveryGrammarParser.DateTime_DateHourContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateHourMinute</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateHourMinute([NotNull] EveryGrammarParser.DateTime_DateHourMinuteContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateHourMinute</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateHourMinute([NotNull] EveryGrammarParser.DateTime_DateHourMinuteContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateHourMinuteSeconds</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateHourMinuteSeconds([NotNull] EveryGrammarParser.DateTime_DateHourMinuteSecondsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateHourMinuteSeconds</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateHourMinuteSeconds([NotNull] EveryGrammarParser.DateTime_DateHourMinuteSecondsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_Full</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_Full([NotNull] EveryGrammarParser.DateTime_FullContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_Full</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_Full([NotNull] EveryGrammarParser.DateTime_FullContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_Indexing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_Indexing([NotNull] EveryGrammarParser.ArraySlicing_IndexingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Indexing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Indexing([NotNull] EveryGrammarParser.ArraySlicing_IndexingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_Slicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_Slicing([NotNull] EveryGrammarParser.ArraySlicing_SlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Slicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Slicing([NotNull] EveryGrammarParser.ArraySlicing_SlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_StepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_StepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StepSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StepSlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Concat</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Concat([NotNull] EveryGrammarParser.Function_ConcatContext context) { }

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
        public void EnterFunction_Count([NotNull] EveryGrammarParser.Function_CountContext context) { }

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
        public void EnterFunction_Distinc([NotNull] EveryGrammarParser.Function_DistincContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Distinc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Distinc([NotNull] EveryGrammarParser.Function_DistincContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Duplicates</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Duplicates([NotNull] EveryGrammarParser.Function_DuplicatesContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Duplicates</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Duplicates([NotNull] EveryGrammarParser.Function_DuplicatesContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_IndexOf</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_IndexOf([NotNull] EveryGrammarParser.Function_IndexOfContext context) { }

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
        public void EnterFunction_Lower([NotNull] EveryGrammarParser.Function_LowerContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Lower([NotNull] EveryGrammarParser.Function_LowerContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Reverse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Reverse([NotNull] EveryGrammarParser.Function_ReverseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Reverse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Reverse([NotNull] EveryGrammarParser.Function_ReverseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Upper</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Upper([NotNull] EveryGrammarParser.Function_UpperContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Upper</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Upper([NotNull] EveryGrammarParser.Function_UpperContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Abs</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Abs([NotNull] EveryGrammarParser.Math_AbsContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Abs</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Abs([NotNull] EveryGrammarParser.Math_AbsContext context)
        {
            Func<object, object> calculation = x => (object)Math.Abs(Convert.ToDecimal(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACos([NotNull] EveryGrammarParser.Math_ACosContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACos([NotNull] EveryGrammarParser.Math_ACosContext context)
        {
            Func<object, object> calculation = x => (object)Math.Acos(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACosH([NotNull] EveryGrammarParser.Math_ACosHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACosH([NotNull] EveryGrammarParser.Math_ACosHContext context)
        {
            Func<object, object> calculation = x => (object)MathNet.Numerics.Trig.Acosh(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASin([NotNull] EveryGrammarParser.Math_ASinContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASin([NotNull] EveryGrammarParser.Math_ASinContext context)
        {
            Func<object, object> calculation = x => (object)Math.Asin(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASinH([NotNull] EveryGrammarParser.Math_ASinHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASinH([NotNull] EveryGrammarParser.Math_ASinHContext context)
        {
            Func<object, object> calculation = x => (object)MathNet.Numerics.Trig.Asinh(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ATan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ATan([NotNull] EveryGrammarParser.Math_ATanContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ATan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ATan([NotNull] EveryGrammarParser.Math_ATanContext context)
        {
            Func<object, object> calculation = x => (object)Math.Atan(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ATan2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ATan2([NotNull] EveryGrammarParser.Math_ATan2Context context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ATan2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ATan2([NotNull] EveryGrammarParser.Math_ATan2Context context)
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

            var list1 = childValues[0] as List<object>;
            double value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDouble(childValues[0]);

            var list2 = childValues[1] as List<object>;
            double value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDouble(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = Math.Atan2(value1, value2);
            }
            else if (!(list1 is null))
            {
                if (list2 is null)
                {
                    Node.Value = list1.Select(x => (object)Math.Atan2(Convert.ToDouble(x), value2)).ToList();
                }
                else if (list1.Count == list2.Count)
                {
                    var result = new List<object>(list1.Count);
                    for (int i = 0; i < list1.Count; i += 1)
                        result.Add(Math.Atan2(Convert.ToDouble(list1[i]), Convert.ToDouble(list2[i])));
                    Node.Value = result;
                }
                else
                {
                    ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {list1.Count} Array2 Count {list2.Count}");
                    Node.Value = new List<object>();
                }
            }
            else
            {
                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, "If first parameter is an array, all parameters must be an array");
                Node.Value = new List<object>();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ATanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ATanH([NotNull] EveryGrammarParser.Math_ATanHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ATanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ATanH([NotNull] EveryGrammarParser.Math_ATanHContext context)
        {
            Func<object, object> calculation = x => (object)MathNet.Numerics.Trig.Atanh(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Cbrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Cbrt([NotNull] EveryGrammarParser.Math_CbrtContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Cbrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Cbrt([NotNull] EveryGrammarParser.Math_CbrtContext context)
        {
            Func<object, object> calculation = x => (object)Math.Pow(Convert.ToDouble(x), 1d / 3d);
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Cos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Cos([NotNull] EveryGrammarParser.Math_CosContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Cos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Cos([NotNull] EveryGrammarParser.Math_CosContext context)
        {
            Func<object, object> calculation = x => (object)Math.Cos(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CosH([NotNull] EveryGrammarParser.Math_CosHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CosH([NotNull] EveryGrammarParser.Math_CosHContext context)
        {
            Func<object, object> calculation = x => (object)Math.Cosh(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Ceilling</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Ceilling([NotNull] EveryGrammarParser.Math_CeillingContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Ceilling</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Ceilling([NotNull] EveryGrammarParser.Math_CeillingContext context)
        {
            Func<object, object> calculation = x => (object)Math.Ceiling(Convert.ToDecimal(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Clamp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Clamp([NotNull] EveryGrammarParser.Math_ClampContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Clamp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Clamp([NotNull] EveryGrammarParser.Math_ClampContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 3, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues) ||
                !ErrorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            var valueList = childValues[0] as List<object>;
            decimal value = 0;
            if (valueList is null)
                value = Convert.ToDecimal(childValues[0]);

            var minList = childValues[1] as List<object>;
            decimal min = 0;
            if (minList is null)
                min = Convert.ToDecimal(childValues[1]);

            var maxList = childValues[2] as List<object>;
            decimal max = 0;
            if (maxList is null)
                max = Convert.ToDecimal(childValues[2]);

            if (valueList is null && minList is null && maxList is null)
            {
                Node.Value = value < min ? min : value > max ? max : value;
            }
            else if (!(valueList is null))
            {
                if (minList is null && maxList is null)
                {
                    Node.Value = valueList.Select(x =>
                    {
                        decimal valueX = Convert.ToDecimal(x);
                        return (object)(valueX < min ? min : valueX > max ? max : value);
                    }).ToList();
                }
                else if (minList is null || maxList is null)
                {
                    ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, "If any parameter is an array, all parameters must be an array");
                    Node.Value = new List<object>();
                }
                else if (valueList.Count == minList.Count && minList.Count == maxList.Count)
                {
                    var result = new List<object>(valueList.Count);
                    for (int i = 0; i < valueList.Count; i += 1)
                    {
                        decimal valueX = Convert.ToDecimal(valueList[i]);
                        decimal minX = Convert.ToDecimal(minList[i]);
                        decimal maxX = Convert.ToDecimal(maxList[i]);

                        result.Add(valueX < minX ? minX : valueX > maxX ? maxX : valueX);
                    }
                    Node.Value = result;
                }
                else
                {
                    ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount,
                        $"Array count must be equal: Array1 Count {valueList.Count} Array2 Count {minList.Count} Array3 Count {maxList.Count}");
                    Node.Value = new List<object>();
                }
            }
            else
            {
                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, "If any parameter is an array, all parameters must be an array");
                Node.Value = new List<object>();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CrossSum</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CrossSum([NotNull] EveryGrammarParser.Math_CrossSumContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CrossSum</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CrossSum([NotNull] EveryGrammarParser.Math_CrossSumContext context)
        {
            Func<object, object> calculation = x =>
            {
                long value = 0;
                foreach (var letter in Convert.ToInt64(x).ToString())
                    value += long.Parse(letter.ToString());
                return (object)value;
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Derivative</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Derivative([NotNull] EveryGrammarParser.Math_DerivativeContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Derivative</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Derivative([NotNull] EveryGrammarParser.Math_DerivativeContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Exp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Exp([NotNull] EveryGrammarParser.Math_ExpContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Exp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Exp([NotNull] EveryGrammarParser.Math_ExpContext context)
        {
            Func<object, object> calculation = x => (object)Math.Exp(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Floor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Floor([NotNull] EveryGrammarParser.Math_FloorContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Floor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Floor([NotNull] EveryGrammarParser.Math_FloorContext context)
        {
            Func<object, object> calculation = x => (object)Math.Floor(Convert.ToDecimal(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Integration</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Integration([NotNull] EveryGrammarParser.Math_IntegrationContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Integration</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Integration([NotNull] EveryGrammarParser.Math_IntegrationContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Log</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Log([NotNull] EveryGrammarParser.Math_LogContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Log</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Log([NotNull] EveryGrammarParser.Math_LogContext context)
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

            var list1 = childValues[0] as List<object>;
            double value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDouble(childValues[0]);

            var list2 = childValues[1] as List<object>;
            double value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDouble(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = Math.Log(value1, value2);
            }
            else if (!(list1 is null))
            {
                if (list2 is null)
                {
                    Node.Value = list1.Select(x => (object)Math.Log(Convert.ToDouble(x), value2)).ToList();
                }
                else if (list1.Count == list2.Count)
                {
                    var result = new List<object>(list1.Count);
                    for (int i = 0; i < list1.Count; i += 1)
                        result.Add(Math.Log(Convert.ToDouble(list1[i]), Convert.ToDouble(list2[i])));
                    Node.Value = result;
                }
                else
                {
                    ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {list1.Count} Array2 Count {list2.Count}");
                    Node.Value = new List<object>();
                }
            }
            else
            {
                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, "If first parameter is an array, all parameters must be an array");
                Node.Value = new List<object>();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Log2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Log2([NotNull] EveryGrammarParser.Math_Log2Context context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Log2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Log2([NotNull] EveryGrammarParser.Math_Log2Context context)
        {
            Func<object, object> calculation = x => (object)Math.Log(Convert.ToDouble(x), 2d);
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Log10</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Log10([NotNull] EveryGrammarParser.Math_Log10Context context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Log10</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Log10([NotNull] EveryGrammarParser.Math_Log10Context context)
        {
            Func<object, object> calculation = x => (object)Math.Log10(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Max_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Max_Array([NotNull] EveryGrammarParser.Math_Max_ArrayContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Max_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Max_Array([NotNull] EveryGrammarParser.Math_Max_ArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Max_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Max_Two([NotNull] EveryGrammarParser.Math_Max_TwoContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Max_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Max_Two([NotNull] EveryGrammarParser.Math_Max_TwoContext context)
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
                !ErrorCollector.CheckIsNumber(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            Node.Value = Math.Max(Convert.ToDouble(childValues[0]), Convert.ToDouble(childValues[1]));
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Min_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Min_Array([NotNull] EveryGrammarParser.Math_Min_ArrayContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Min_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Min_Array([NotNull] EveryGrammarParser.Math_Min_ArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Min_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Min_Two([NotNull] EveryGrammarParser.Math_Min_TwoContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Min_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Min_Two([NotNull] EveryGrammarParser.Math_Min_TwoContext context)
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
                !ErrorCollector.CheckIsNumber(context, childValues))
            {
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            Node.Value = Math.Min(Convert.ToDouble(childValues[0]), Convert.ToDouble(childValues[1]));
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Power</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Power([NotNull] EveryGrammarParser.Math_PowerContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Power</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Power([NotNull] EveryGrammarParser.Math_PowerContext context)
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

            var list1 = childValues[0] as List<object>;
            double value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDouble(childValues[0]);

            var list2 = childValues[1] as List<object>;
            double value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDouble(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = Math.Pow(value1, value2);
            }
            else if (!(list1 is null))
            {
                if (list2 is null)
                {
                    Node.Value = list1.Select(x => (object)Math.Pow(Convert.ToDouble(x), value2)).ToList();
                }
                else if (list1.Count == list2.Count)
                {
                    var result = new List<object>(list1.Count);
                    for (int i = 0; i < list1.Count; i += 1)
                        result.Add(Math.Pow(Convert.ToDouble(list1[i]), Convert.ToDouble(list2[i])));
                    Node.Value = result;
                }
                else
                {
                    ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {list1.Count} Array2 Count {list2.Count}");
                    Node.Value = new List<object>();
                }
            }
            else
            {
                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, "If first parameter is an array, all parameters must be an array");
                Node.Value = new List<object>();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Round_Not_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Round_Not_Decimal([NotNull] EveryGrammarParser.Math_Round_Not_DecimalContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Round_Not_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Round_Not_Decimal([NotNull] EveryGrammarParser.Math_Round_Not_DecimalContext context)
        {
            Func<object, object> calculation = x => (object)Math.Round(Convert.ToDecimal(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Round_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Round_Decimal([NotNull] EveryGrammarParser.Math_Round_DecimalContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Round_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Round_Decimal([NotNull] EveryGrammarParser.Math_Round_DecimalContext context)
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

            var list1 = childValues[0] as List<object>;
            decimal value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDecimal(childValues[0]);

            var list2 = childValues[1] as List<object>;
            int value2 = 0;
            if (list2 is null)
                value2 = Convert.ToInt32(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = Math.Round(value1, value2);
            }
            else if (!(list1 is null))
            {
                if (list2 is null)
                {
                    Node.Value = list1.Select(x => (object)Math.Round(Convert.ToDecimal(x), value2)).ToList();
                }
                else if (list1.Count == list2.Count)
                {
                    var result = new List<object>(list1.Count);
                    for (int i = 0; i < list1.Count; i += 1)
                        result.Add(Math.Round(Convert.ToDecimal(list1[i]), Convert.ToInt32(list2[i])));
                    Node.Value = result;
                }
                else
                {
                    ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {list1.Count} Array2 Count {list2.Count}");
                    Node.Value = new List<object>();
                }
            }
            else
            {
                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, "If first parameter is an array, all parameters must be an array");
                Node.Value = new List<object>();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Root</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Root([NotNull] EveryGrammarParser.Math_RootContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Root</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Root([NotNull] EveryGrammarParser.Math_RootContext context)
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

            var list1 = childValues[0] as List<object>;
            double value1 = 0;
            if (list1 is null)
                value1 = Convert.ToDouble(childValues[0]);

            var list2 = childValues[1] as List<object>;
            double value2 = 0;
            if (list2 is null)
                value2 = Convert.ToDouble(childValues[1]);

            if (list1 is null && list2 is null)
            {
                Node.Value = Math.Pow(value1, 1 / value2);
            }
            else if (!(list1 is null))
            {
                if (list2 is null)
                {
                    Node.Value = list1.Select(x => (object)Math.Pow(Convert.ToDouble(x), 1 / value2)).ToList();
                }
                else if (list1.Count == list2.Count)
                {
                    var result = new List<object>(list1.Count);
                    for (int i = 0; i < list1.Count; i += 1)
                        result.Add(Math.Pow(Convert.ToDouble(list1[i]), 1d / Convert.ToDouble(childValues[1])));
                    Node.Value = result;
                }
                else
                {
                    ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {list1.Count} Array2 Count {list2.Count}");
                    Node.Value = new List<object>();
                }
            }
            else
            {
                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, "If first parameter is an array, all parameters must be an array");
                Node.Value = new List<object>();
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Sin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Sin([NotNull] EveryGrammarParser.Math_SinContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Sin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Sin([NotNull] EveryGrammarParser.Math_SinContext context)
        {
            Func<object, object> calculation = x => (object)Math.Sin(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_SinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_SinH([NotNull] EveryGrammarParser.Math_SinHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_SinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_SinH([NotNull] EveryGrammarParser.Math_SinHContext context)
        {
            Func<object, object> calculation = x => (object)Math.Sinh(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Sqrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Sqrt([NotNull] EveryGrammarParser.Math_SqrtContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Sqrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Sqrt([NotNull] EveryGrammarParser.Math_SqrtContext context)
        {
            Func<object, object> calculation = x => (object)Math.Sqrt(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Tan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Tan([NotNull] EveryGrammarParser.Math_TanContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Tan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Tan([NotNull] EveryGrammarParser.Math_TanContext context)
        {
            Func<object, object> calculation = x => (object)Math.Tan(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_TanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_TanH([NotNull] EveryGrammarParser.Math_TanHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_TanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_TanH([NotNull] EveryGrammarParser.Math_TanHContext context)
        {
            Func<object, object> calculation = x => (object)Math.Tanh(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Truncate</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Truncate([NotNull] EveryGrammarParser.Math_TruncateContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Truncate</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Truncate([NotNull] EveryGrammarParser.Math_TruncateContext context)
        {
            Func<object, object> calculation = x => (object)Math.Truncate(Convert.ToDecimal(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Mean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Mean([NotNull] EveryGrammarParser.MathStatistic_MeanContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Mean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Mean([NotNull] EveryGrammarParser.MathStatistic_MeanContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Median</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Median([NotNull] EveryGrammarParser.MathStatistic_MedianContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Median</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Median([NotNull] EveryGrammarParser.MathStatistic_MedianContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Variance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Variance([NotNull] EveryGrammarParser.MathStatistic_VarianceContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Variance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Variance([NotNull] EveryGrammarParser.MathStatistic_VarianceContext context) { }

        /// <summary>
        /// Enter a parse tree produced by <see cref="EveryGrammarParser.expr_args"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterExpr_args([NotNull] EveryGrammarParser.Expr_argsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by <see cref="EveryGrammarParser.expr_args"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitExpr_args([NotNull] EveryGrammarParser.Expr_argsContext context) { }

        /// Enter a parse tree produced by the <c>ArrayCreation_Empty</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArrayCreation_Empty([NotNull] EveryGrammarParser.ArrayCreation_EmptyContext context)
        {
            Node.AddChildNode(new List<object>());
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArrayCreation_Empty</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArrayCreation_Empty([NotNull] EveryGrammarParser.ArrayCreation_EmptyContext context) { }

        /// Enter a parse tree produced by the <c>ArrayCreation</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArrayCreation([NotNull] EveryGrammarParser.ArrayCreationContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArrayCreation</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArrayCreation([NotNull] EveryGrammarParser.ArrayCreationContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = new List<object>();
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (ErrorCollector.CheckIsNull(context, childValues))
            {
                Node.Value = new List<object>();
                Node = Node.Parent;
                return;
            }

            Node.Value = new List<object>(childValues);
            Node = Node.Parent;
        }

        /// <inheritdoc/>
        /// <remarks>The default implementation does nothing.</remarks>
        public void EnterEveryRule([NotNull] ParserRuleContext context) { }

        /// <inheritdoc/>
        /// <remarks>The default implementation does nothing.</remarks>
        public void ExitEveryRule([NotNull] ParserRuleContext context) { }

        /// <inheritdoc/>
        /// <remarks>The default implementation does nothing.</remarks>
        public void VisitTerminal([NotNull] ITerminalNode node) { }

        /// <inheritdoc/>
        /// <remarks>The default implementation does nothing.</remarks>
        public void VisitErrorNode([NotNull] IErrorNode node) { }
    }
}