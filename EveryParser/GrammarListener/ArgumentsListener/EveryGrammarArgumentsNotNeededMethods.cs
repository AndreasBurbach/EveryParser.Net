using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace EveryParser.GrammarListener.ArgumentsListener
{
    /// <summary>
    /// This interface defines a complete listener for a parse tree produced by
    /// <see cref="EveryGrammarParser"/>.
    /// </summary>
    public partial class EveryGrammarArgumentsListener
    {
        /// <summary>
        /// Enter a parse tree produced by <see cref="EveryGrammarParser.startRule"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterStartRule([NotNull] EveryGrammarParser.StartRuleContext context) { }

        /// <summary>
        /// Exit a parse tree produced by <see cref="EveryGrammarParser.startRule"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitStartRule([NotNull] EveryGrammarParser.StartRuleContext context) { }

        /// <summary>
        /// Enter a parse tree produced by <see cref="EveryGrammarParser.expression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterExpression([NotNull] EveryGrammarParser.ExpressionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by <see cref="EveryGrammarParser.expression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitExpression([NotNull] EveryGrammarParser.ExpressionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>IfElse_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterIfElse_Next([NotNull] EveryGrammarParser.IfElse_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>IfElse_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitIfElse_Next([NotNull] EveryGrammarParser.IfElse_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing([NotNull] EveryGrammarParser.ArraySlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing([NotNull] EveryGrammarParser.ArraySlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>IfElse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterIfElse([NotNull] EveryGrammarParser.IfElseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>IfElse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitIfElse([NotNull] EveryGrammarParser.IfElseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>InnerIfElse_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.inner_if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterInnerIfElse_Next([NotNull] EveryGrammarParser.InnerIfElse_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>InnerIfElse_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.inner_if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitInnerIfElse_Next([NotNull] EveryGrammarParser.InnerIfElse_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>InnerIfElse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.inner_if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterInnerIfElse([NotNull] EveryGrammarParser.InnerIfElseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>InnerIfElse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.inner_if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitInnerIfElse([NotNull] EveryGrammarParser.InnerIfElseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolOr_Next([NotNull] EveryGrammarParser.BoolOr_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolOr_Next([NotNull] EveryGrammarParser.BoolOr_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolOr([NotNull] EveryGrammarParser.BoolOrContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolOr([NotNull] EveryGrammarParser.BoolOrContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolXOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_xor_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolXOr_Next([NotNull] EveryGrammarParser.BoolXOr_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolXOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_xor_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolXOr_Next([NotNull] EveryGrammarParser.BoolXOr_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolXOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_xor_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolXOr([NotNull] EveryGrammarParser.BoolXOrContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolXOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_xor_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolXOr([NotNull] EveryGrammarParser.BoolXOrContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolAnd_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolAnd_Next([NotNull] EveryGrammarParser.BoolAnd_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolAnd_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolAnd_Next([NotNull] EveryGrammarParser.BoolAnd_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolAnd([NotNull] EveryGrammarParser.BoolAndContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolAnd([NotNull] EveryGrammarParser.BoolAndContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_Contains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_Contains([NotNull] EveryGrammarParser.Equality_ContainsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_Contains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_Contains([NotNull] EveryGrammarParser.Equality_ContainsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_Next([NotNull] EveryGrammarParser.Equality_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_Next([NotNull] EveryGrammarParser.Equality_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_Equal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_Equal([NotNull] EveryGrammarParser.Equality_EqualContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_Equal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_Equal([NotNull] EveryGrammarParser.Equality_EqualContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_NotEqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_NotEqualIgnoreCase([NotNull] EveryGrammarParser.Equality_NotEqualIgnoreCaseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_NotEqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_NotEqualIgnoreCase([NotNull] EveryGrammarParser.Equality_NotEqualIgnoreCaseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_NotEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_NotEqual([NotNull] EveryGrammarParser.Equality_NotEqualContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_NotEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_NotEqual([NotNull] EveryGrammarParser.Equality_NotEqualContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_NotContains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_NotContains([NotNull] EveryGrammarParser.Equality_NotContainsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_NotContains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_NotContains([NotNull] EveryGrammarParser.Equality_NotContainsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_EqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_EqualIgnoreCase([NotNull] EveryGrammarParser.Equality_EqualIgnoreCaseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_EqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_EqualIgnoreCase([NotNull] EveryGrammarParser.Equality_EqualIgnoreCaseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_Next([NotNull] EveryGrammarParser.Check_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_Next([NotNull] EveryGrammarParser.Check_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_Greater</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_Greater([NotNull] EveryGrammarParser.Check_GreaterContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_Greater</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_Greater([NotNull] EveryGrammarParser.Check_GreaterContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_GreaterEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_GreaterEqual([NotNull] EveryGrammarParser.Check_GreaterEqualContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_GreaterEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_GreaterEqual([NotNull] EveryGrammarParser.Check_GreaterEqualContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_Lower([NotNull] EveryGrammarParser.Check_LowerContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_Lower([NotNull] EveryGrammarParser.Check_LowerContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_LowerEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_LowerEqual([NotNull] EveryGrammarParser.Check_LowerEqualContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_LowerEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_LowerEqual([NotNull] EveryGrammarParser.Check_LowerEqualContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitOR</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitOR([NotNull] EveryGrammarParser.BitORContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitOR</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitOR([NotNull] EveryGrammarParser.BitORContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitOr_Next([NotNull] EveryGrammarParser.BitOr_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitOr_Next([NotNull] EveryGrammarParser.BitOr_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitAnd([NotNull] EveryGrammarParser.BitAndContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitAnd([NotNull] EveryGrammarParser.BitAndContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitAnd_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitAnd_Next([NotNull] EveryGrammarParser.BitAnd_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitAnd_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitAnd_Next([NotNull] EveryGrammarParser.BitAnd_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Line_Addition</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterLine_Addition([NotNull] EveryGrammarParser.Line_AdditionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Line_Addition</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitLine_Addition([NotNull] EveryGrammarParser.Line_AdditionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Line_Subtraction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterLine_Subtraction([NotNull] EveryGrammarParser.Line_SubtractionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Line_Subtraction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitLine_Subtraction([NotNull] EveryGrammarParser.Line_SubtractionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Line_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterLine_Next([NotNull] EveryGrammarParser.Line_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Line_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitLine_Next([NotNull] EveryGrammarParser.Line_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_PowerOperator</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_PowerOperator([NotNull] EveryGrammarParser.PointTerm_PowerOperatorContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_PowerOperator</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_PowerOperator([NotNull] EveryGrammarParser.PointTerm_PowerOperatorContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Modulo</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Modulo([NotNull] EveryGrammarParser.PointTerm_ModuloContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Modulo</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Modulo([NotNull] EveryGrammarParser.PointTerm_ModuloContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Multiply</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Multiply([NotNull] EveryGrammarParser.PointTerm_MultiplyContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Multiply</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Multiply([NotNull] EveryGrammarParser.PointTerm_MultiplyContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_BitShiftLeft</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_BitShiftLeft([NotNull] EveryGrammarParser.PointTerm_BitShiftLeftContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_BitShiftLeft</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_BitShiftLeft([NotNull] EveryGrammarParser.PointTerm_BitShiftLeftContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_IntegerDivision</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_IntegerDivision([NotNull] EveryGrammarParser.PointTerm_IntegerDivisionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_IntegerDivision</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_IntegerDivision([NotNull] EveryGrammarParser.PointTerm_IntegerDivisionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_BitShiftRight</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_BitShiftRight([NotNull] EveryGrammarParser.PointTerm_BitShiftRightContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_BitShiftRight</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_BitShiftRight([NotNull] EveryGrammarParser.PointTerm_BitShiftRightContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Divide</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Divide([NotNull] EveryGrammarParser.PointTerm_DivideContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Divide</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Divide([NotNull] EveryGrammarParser.PointTerm_DivideContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Next([NotNull] EveryGrammarParser.PointTerm_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Next([NotNull] EveryGrammarParser.PointTerm_NextContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Not</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Not([NotNull] EveryGrammarParser.Factor_NotContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Not</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Not([NotNull] EveryGrammarParser.Factor_NotContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Minus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Minus([NotNull] EveryGrammarParser.Factor_MinusContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Minus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Minus([NotNull] EveryGrammarParser.Factor_MinusContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Plus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Plus([NotNull] EveryGrammarParser.Factor_PlusContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Plus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Plus([NotNull] EveryGrammarParser.Factor_PlusContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Tilde</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Tilde([NotNull] EveryGrammarParser.Factor_TildeContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Tilde</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Tilde([NotNull] EveryGrammarParser.Factor_TildeContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Factorial</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Factorial([NotNull] EveryGrammarParser.Factor_FactorialContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Factorial</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Factorial([NotNull] EveryGrammarParser.Factor_FactorialContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Brackets</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Brackets([NotNull] EveryGrammarParser.Factor_BracketsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Brackets</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Brackets([NotNull] EveryGrammarParser.Factor_BracketsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_True</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_True([NotNull] EveryGrammarParser.Factor_TrueContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_True</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_True([NotNull] EveryGrammarParser.Factor_TrueContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_False</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_False([NotNull] EveryGrammarParser.Factor_FalseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_False</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_False([NotNull] EveryGrammarParser.Factor_FalseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Integer([NotNull] EveryGrammarParser.Factor_IntegerContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Integer([NotNull] EveryGrammarParser.Factor_IntegerContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Double</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Double([NotNull] EveryGrammarParser.Factor_DoubleContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Double</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Double([NotNull] EveryGrammarParser.Factor_DoubleContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_String</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_String([NotNull] EveryGrammarParser.Factor_StringContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_String</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_String([NotNull] EveryGrammarParser.Factor_StringContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_DateTimeTerm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_DateTimeTerm([NotNull] EveryGrammarParser.Factor_DateTimeTermContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_DateTimeTerm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_DateTimeTerm([NotNull] EveryGrammarParser.Factor_DateTimeTermContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Array([NotNull] EveryGrammarParser.Factor_ArrayContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Array([NotNull] EveryGrammarParser.Factor_ArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_DefaultFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_DefaultFunction([NotNull] EveryGrammarParser.Factor_DefaultFunctionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_DefaultFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_DefaultFunction([NotNull] EveryGrammarParser.Factor_DefaultFunctionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_CheckFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_CheckFunction([NotNull] EveryGrammarParser.Factor_CheckFunctionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_CheckFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_CheckFunction([NotNull] EveryGrammarParser.Factor_CheckFunctionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_ConvertFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_ConvertFunction([NotNull] EveryGrammarParser.Factor_ConvertFunctionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_ConvertFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_ConvertFunction([NotNull] EveryGrammarParser.Factor_ConvertFunctionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_MathFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_MathFunction([NotNull] EveryGrammarParser.Factor_MathFunctionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_MathFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_MathFunction([NotNull] EveryGrammarParser.Factor_MathFunctionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_RandomFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_RandomFunction([NotNull] EveryGrammarParser.Factor_RandomFunctionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_RandomFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_RandomFunction([NotNull] EveryGrammarParser.Factor_RandomFunctionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_StatisticMathFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_StatisticMathFunction([NotNull] EveryGrammarParser.Factor_StatisticMathFunctionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_StatisticMathFunction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_StatisticMathFunction([NotNull] EveryGrammarParser.Factor_StatisticMathFunctionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_Decimal([NotNull] EveryGrammarParser.Random_DecimalContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_Decimal([NotNull] EveryGrammarParser.Random_DecimalContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_DecimalArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_DecimalArray([NotNull] EveryGrammarParser.Random_DecimalArrayContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_DecimalArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_DecimalArray([NotNull] EveryGrammarParser.Random_DecimalArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_DecimalMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_DecimalMinMax([NotNull] EveryGrammarParser.Random_DecimalMinMaxContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_DecimalMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_DecimalMinMax([NotNull] EveryGrammarParser.Random_DecimalMinMaxContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_DecimalArrayMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_DecimalArrayMinMax([NotNull] EveryGrammarParser.Random_DecimalArrayMinMaxContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_DecimalArrayMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_DecimalArrayMinMax([NotNull] EveryGrammarParser.Random_DecimalArrayMinMaxContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_Integer([NotNull] EveryGrammarParser.Random_IntegerContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_Integer([NotNull] EveryGrammarParser.Random_IntegerContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_IntegerArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_IntegerArray([NotNull] EveryGrammarParser.Random_IntegerArrayContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_IntegerArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_IntegerArray([NotNull] EveryGrammarParser.Random_IntegerArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_IntegerMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_IntegerMinMax([NotNull] EveryGrammarParser.Random_IntegerMinMaxContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_IntegerMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_IntegerMinMax([NotNull] EveryGrammarParser.Random_IntegerMinMaxContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_IntegerArrayMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_IntegerArrayMinMax([NotNull] EveryGrammarParser.Random_IntegerArrayMinMaxContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_IntegerArrayMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_IntegerArrayMinMax([NotNull] EveryGrammarParser.Random_IntegerArrayMinMaxContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_ToArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_ToArray([NotNull] EveryGrammarParser.Convert_ToArrayContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_ToArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_ToArray([NotNull] EveryGrammarParser.Convert_ToArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_ToBoolean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_ToBoolean([NotNull] EveryGrammarParser.Convert_ToBooleanContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_ToBoolean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_ToBoolean([NotNull] EveryGrammarParser.Convert_ToBooleanContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_ToNumber</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_ToNumber([NotNull] EveryGrammarParser.Convert_ToNumberContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_ToNumber</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_ToNumber([NotNull] EveryGrammarParser.Convert_ToNumberContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_ToString</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_ToString([NotNull] EveryGrammarParser.Convert_ToStringContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_ToString</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_ToString([NotNull] EveryGrammarParser.Convert_ToStringContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_DegreeToGrad</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_DegreeToGrad([NotNull] EveryGrammarParser.Convert_DegreeToGradContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_DegreeToGrad</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_DegreeToGrad([NotNull] EveryGrammarParser.Convert_DegreeToGradContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_DegreeToRadian</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_DegreeToRadian([NotNull] EveryGrammarParser.Convert_DegreeToRadianContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_DegreeToRadian</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_DegreeToRadian([NotNull] EveryGrammarParser.Convert_DegreeToRadianContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_GradToDegree</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_GradToDegree([NotNull] EveryGrammarParser.Convert_GradToDegreeContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_GradToDegree</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_GradToDegree([NotNull] EveryGrammarParser.Convert_GradToDegreeContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_GradToRadian</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_GradToRadian([NotNull] EveryGrammarParser.Convert_GradToRadianContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_GradToRadian</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_GradToRadian([NotNull] EveryGrammarParser.Convert_GradToRadianContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_RadianToDegree</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_RadianToDegree([NotNull] EveryGrammarParser.Convert_RadianToDegreeContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_RadianToDegree</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_RadianToDegree([NotNull] EveryGrammarParser.Convert_RadianToDegreeContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_RadianToGrad</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_RadianToGrad([NotNull] EveryGrammarParser.Convert_RadianToGradContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_RadianToGrad</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_RadianToGrad([NotNull] EveryGrammarParser.Convert_RadianToGradContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_Expression</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_Expression([NotNull] EveryGrammarParser.DateTime_ExpressionContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_Expression</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_Expression([NotNull] EveryGrammarParser.DateTime_ExpressionContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateEntry</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateEntry([NotNull] EveryGrammarParser.DateTime_DateEntryContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateEntry</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateEntry([NotNull] EveryGrammarParser.DateTime_DateEntryContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateHour</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateHour([NotNull] EveryGrammarParser.DateTime_DateHourContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateHour</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateHour([NotNull] EveryGrammarParser.DateTime_DateHourContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateHourMinute</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateHourMinute([NotNull] EveryGrammarParser.DateTime_DateHourMinuteContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateHourMinute</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateHourMinute([NotNull] EveryGrammarParser.DateTime_DateHourMinuteContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateHourMinuteSeconds</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateHourMinuteSeconds([NotNull] EveryGrammarParser.DateTime_DateHourMinuteSecondsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateHourMinuteSeconds</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateHourMinuteSeconds([NotNull] EveryGrammarParser.DateTime_DateHourMinuteSecondsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_Full</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_Full([NotNull] EveryGrammarParser.DateTime_FullContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_Full</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_Full([NotNull] EveryGrammarParser.DateTime_FullContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_Indexing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_Indexing([NotNull] EveryGrammarParser.ArraySlicing_IndexingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Indexing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Indexing([NotNull] EveryGrammarParser.ArraySlicing_IndexingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_Slicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_Slicing([NotNull] EveryGrammarParser.ArraySlicing_SlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Slicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Slicing([NotNull] EveryGrammarParser.ArraySlicing_SlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_StepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_StepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StepSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StepSlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_StartSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_StartSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StartSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StartSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartSlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_StartStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_StartStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartStepSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StartStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StartStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartStepSlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_EndSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_EndSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_EndSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_EndSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndSlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_EndStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_EndStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndStepSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_EndStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_EndStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndStepSlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_AllStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_AllStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_AllStepSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_AllStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_AllStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_AllStepSlicingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsArray([NotNull] EveryGrammarParser.CheckFunction_IsArrayContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsArray([NotNull] EveryGrammarParser.CheckFunction_IsArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsBoolean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsBoolean([NotNull] EveryGrammarParser.CheckFunction_IsBooleanContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsBoolean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsBoolean([NotNull] EveryGrammarParser.CheckFunction_IsBooleanContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsDateTime</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsDateTime([NotNull] EveryGrammarParser.CheckFunction_IsDateTimeContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsDateTime</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsDateTime([NotNull] EveryGrammarParser.CheckFunction_IsDateTimeContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsNull</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsNull([NotNull] EveryGrammarParser.CheckFunction_IsNullContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsNull</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsNull([NotNull] EveryGrammarParser.CheckFunction_IsNullContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsNumber</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsNumber([NotNull] EveryGrammarParser.CheckFunction_IsNumberContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsNumber</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsNumber([NotNull] EveryGrammarParser.CheckFunction_IsNumberContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsString</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsString([NotNull] EveryGrammarParser.CheckFunction_IsStringContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsString</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsString([NotNull] EveryGrammarParser.CheckFunction_IsStringContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_IsWhitespace</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_IsWhitespace([NotNull] EveryGrammarParser.CheckFunction_IsWhitespaceContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_IsWhitespace</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_IsWhitespace([NotNull] EveryGrammarParser.CheckFunction_IsWhitespaceContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_HasAny</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_HasAny([NotNull] EveryGrammarParser.CheckFunction_HasAnyContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_HasAny</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_HasAny([NotNull] EveryGrammarParser.CheckFunction_HasAnyContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_HasDuplicates</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_HasDuplicates([NotNull] EveryGrammarParser.CheckFunction_HasDuplicatesContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_HasDuplicates</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_HasDuplicates([NotNull] EveryGrammarParser.CheckFunction_HasDuplicatesContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Concat</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Concat([NotNull] EveryGrammarParser.Function_ConcatContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Concat</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Concat([NotNull] EveryGrammarParser.Function_ConcatContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Count</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Count([NotNull] EveryGrammarParser.Function_CountContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Count</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Count([NotNull] EveryGrammarParser.Function_CountContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Distinc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Distinc([NotNull] EveryGrammarParser.Function_DistincContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Distinc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Distinc([NotNull] EveryGrammarParser.Function_DistincContext context) { }

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
        /// Enter a parse tree produced by the <c>Function_IndexOf</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_IndexOf([NotNull] EveryGrammarParser.Function_IndexOfContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_IndexOf</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_IndexOf([NotNull] EveryGrammarParser.Function_IndexOfContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_IndexOfStart</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_IndexOfStart([NotNull] EveryGrammarParser.Function_IndexOfStartContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_IndexOfStart</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_IndexOfStart([NotNull] EveryGrammarParser.Function_IndexOfStartContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_IndexOfStartEnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_IndexOfStartEnd([NotNull] EveryGrammarParser.Function_IndexOfStartEndContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_IndexOfStartEnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_IndexOfStartEnd([NotNull] EveryGrammarParser.Function_IndexOfStartEndContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Lower([NotNull] EveryGrammarParser.Function_LowerContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Lower([NotNull] EveryGrammarParser.Function_LowerContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Reverse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Reverse([NotNull] EveryGrammarParser.Function_ReverseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Reverse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Reverse([NotNull] EveryGrammarParser.Function_ReverseContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Upper</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Upper([NotNull] EveryGrammarParser.Function_UpperContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Upper</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Upper([NotNull] EveryGrammarParser.Function_UpperContext context) { }

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

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Trim</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Trim([NotNull] EveryGrammarParser.Function_TrimContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Trim</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Trim([NotNull] EveryGrammarParser.Function_TrimContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Abs</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Abs([NotNull] EveryGrammarParser.Math_AbsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Abs</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Abs([NotNull] EveryGrammarParser.Math_AbsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACos([NotNull] EveryGrammarParser.Math_ACosContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACos([NotNull] EveryGrammarParser.Math_ACosContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACosH([NotNull] EveryGrammarParser.Math_ACosHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACosH([NotNull] EveryGrammarParser.Math_ACosHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASin([NotNull] EveryGrammarParser.Math_ASinContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASin([NotNull] EveryGrammarParser.Math_ASinContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASinH([NotNull] EveryGrammarParser.Math_ASinHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASinH([NotNull] EveryGrammarParser.Math_ASinHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ATan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ATan([NotNull] EveryGrammarParser.Math_ATanContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ATan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ATan([NotNull] EveryGrammarParser.Math_ATanContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ATan2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ATan2([NotNull] EveryGrammarParser.Math_ATan2Context context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ATan2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ATan2([NotNull] EveryGrammarParser.Math_ATan2Context context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ATanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ATanH([NotNull] EveryGrammarParser.Math_ATanHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ATanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ATanH([NotNull] EveryGrammarParser.Math_ATanHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Cbrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Cbrt([NotNull] EveryGrammarParser.Math_CbrtContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Cbrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Cbrt([NotNull] EveryGrammarParser.Math_CbrtContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Cos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Cos([NotNull] EveryGrammarParser.Math_CosContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Cos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Cos([NotNull] EveryGrammarParser.Math_CosContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CosH([NotNull] EveryGrammarParser.Math_CosHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CosH([NotNull] EveryGrammarParser.Math_CosHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Ceilling</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Ceilling([NotNull] EveryGrammarParser.Math_CeillingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Ceilling</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Ceilling([NotNull] EveryGrammarParser.Math_CeillingContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Clamp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Clamp([NotNull] EveryGrammarParser.Math_ClampContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Clamp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Clamp([NotNull] EveryGrammarParser.Math_ClampContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CrossSum</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CrossSum([NotNull] EveryGrammarParser.Math_CrossSumContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CrossSum</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CrossSum([NotNull] EveryGrammarParser.Math_CrossSumContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Derivative</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Derivative([NotNull] EveryGrammarParser.Math_DerivativeContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Derivative</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Derivative([NotNull] EveryGrammarParser.Math_DerivativeContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Exp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Exp([NotNull] EveryGrammarParser.Math_ExpContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Exp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Exp([NotNull] EveryGrammarParser.Math_ExpContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Floor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Floor([NotNull] EveryGrammarParser.Math_FloorContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Floor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Floor([NotNull] EveryGrammarParser.Math_FloorContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Integration</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Integration([NotNull] EveryGrammarParser.Math_IntegrationContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Integration</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Integration([NotNull] EveryGrammarParser.Math_IntegrationContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Log</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Log([NotNull] EveryGrammarParser.Math_LogContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Log</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Log([NotNull] EveryGrammarParser.Math_LogContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Log2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Log2([NotNull] EveryGrammarParser.Math_Log2Context context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Log2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Log2([NotNull] EveryGrammarParser.Math_Log2Context context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Log10</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Log10([NotNull] EveryGrammarParser.Math_Log10Context context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Log10</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Log10([NotNull] EveryGrammarParser.Math_Log10Context context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Max_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Max_Array([NotNull] EveryGrammarParser.Math_Max_ArrayContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Max_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Max_Array([NotNull] EveryGrammarParser.Math_Max_ArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Max_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Max_Two([NotNull] EveryGrammarParser.Math_Max_TwoContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Max_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Max_Two([NotNull] EveryGrammarParser.Math_Max_TwoContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Min_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Min_Array([NotNull] EveryGrammarParser.Math_Min_ArrayContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Min_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Min_Array([NotNull] EveryGrammarParser.Math_Min_ArrayContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Min_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Min_Two([NotNull] EveryGrammarParser.Math_Min_TwoContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Min_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Min_Two([NotNull] EveryGrammarParser.Math_Min_TwoContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Power</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Power([NotNull] EveryGrammarParser.Math_PowerContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Power</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Power([NotNull] EveryGrammarParser.Math_PowerContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Round_Not_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Round_Not_Decimal([NotNull] EveryGrammarParser.Math_Round_Not_DecimalContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Round_Not_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Round_Not_Decimal([NotNull] EveryGrammarParser.Math_Round_Not_DecimalContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Round_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Round_Decimal([NotNull] EveryGrammarParser.Math_Round_DecimalContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Round_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Round_Decimal([NotNull] EveryGrammarParser.Math_Round_DecimalContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Root</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Root([NotNull] EveryGrammarParser.Math_RootContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Root</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Root([NotNull] EveryGrammarParser.Math_RootContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Sin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Sin([NotNull] EveryGrammarParser.Math_SinContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Sin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Sin([NotNull] EveryGrammarParser.Math_SinContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_SinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_SinH([NotNull] EveryGrammarParser.Math_SinHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_SinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_SinH([NotNull] EveryGrammarParser.Math_SinHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Sqrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Sqrt([NotNull] EveryGrammarParser.Math_SqrtContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Sqrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Sqrt([NotNull] EveryGrammarParser.Math_SqrtContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Tan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Tan([NotNull] EveryGrammarParser.Math_TanContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Tan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Tan([NotNull] EveryGrammarParser.Math_TanContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_TanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_TanH([NotNull] EveryGrammarParser.Math_TanHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_TanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_TanH([NotNull] EveryGrammarParser.Math_TanHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Truncate</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Truncate([NotNull] EveryGrammarParser.Math_TruncateContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Truncate</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Truncate([NotNull] EveryGrammarParser.Math_TruncateContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Norm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Norm([NotNull] EveryGrammarParser.Math_NormContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Norm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Norm([NotNull] EveryGrammarParser.Math_NormContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_EulerNorm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_EulerNorm([NotNull] EveryGrammarParser.Math_EulerNormContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_EulerNorm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_EulerNorm([NotNull] EveryGrammarParser.Math_EulerNormContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_MaxNorm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_MaxNorm([NotNull] EveryGrammarParser.Math_MaxNormContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_MaxNorm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_MaxNorm([NotNull] EveryGrammarParser.Math_MaxNormContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_GreatesCommonDivisor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_GreatesCommonDivisor([NotNull] EveryGrammarParser.Math_GreatesCommonDivisorContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_GreatesCommonDivisor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_GreatesCommonDivisor([NotNull] EveryGrammarParser.Math_GreatesCommonDivisorContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_LeastCommonMultiple</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_LeastCommonMultiple([NotNull] EveryGrammarParser.Math_LeastCommonMultipleContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_LeastCommonMultiple</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_LeastCommonMultiple([NotNull] EveryGrammarParser.Math_LeastCommonMultipleContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_DotProduct</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_DotProduct([NotNull] EveryGrammarParser.Math_DotProductContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_DotProduct</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_DotProduct([NotNull] EveryGrammarParser.Math_DotProductContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Binomila</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Binomila([NotNull] EveryGrammarParser.Math_BinomilaContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Binomila</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Binomila([NotNull] EveryGrammarParser.Math_BinomilaContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACot</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACot([NotNull] EveryGrammarParser.Math_ACotContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACot</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACot([NotNull] EveryGrammarParser.Math_ACotContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACotH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACotH([NotNull] EveryGrammarParser.Math_ACotHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACotH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACotH([NotNull] EveryGrammarParser.Math_ACotHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACsc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACsc([NotNull] EveryGrammarParser.Math_ACscContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACsc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACsc([NotNull] EveryGrammarParser.Math_ACscContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACscH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACscH([NotNull] EveryGrammarParser.Math_ACscHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACscH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACscH([NotNull] EveryGrammarParser.Math_ACscHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASec</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASec([NotNull] EveryGrammarParser.Math_ASecContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASec</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASec([NotNull] EveryGrammarParser.Math_ASecContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASecH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASecH([NotNull] EveryGrammarParser.Math_ASecHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASecH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASecH([NotNull] EveryGrammarParser.Math_ASecHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Cot</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Cot([NotNull] EveryGrammarParser.Math_CotContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Cot</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Cot([NotNull] EveryGrammarParser.Math_CotContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CotH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CotH([NotNull] EveryGrammarParser.Math_CotHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CotH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CotH([NotNull] EveryGrammarParser.Math_CotHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Csc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Csc([NotNull] EveryGrammarParser.Math_CscContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Csc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Csc([NotNull] EveryGrammarParser.Math_CscContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CscH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CscH([NotNull] EveryGrammarParser.Math_CscHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CscH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CscH([NotNull] EveryGrammarParser.Math_CscHContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Sec</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Sec([NotNull] EveryGrammarParser.Math_SecContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Sec</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Sec([NotNull] EveryGrammarParser.Math_SecContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_SecH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_SecH([NotNull] EveryGrammarParser.Math_SecHContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_SecH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_SecH([NotNull] EveryGrammarParser.Math_SecHContext context) { }

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
        /// Enter a parse tree produced by the <c>MathStatistic_Mean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Mean([NotNull] EveryGrammarParser.MathStatistic_MeanContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Mean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Mean([NotNull] EveryGrammarParser.MathStatistic_MeanContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Median</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Median([NotNull] EveryGrammarParser.MathStatistic_MedianContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Median</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Median([NotNull] EveryGrammarParser.MathStatistic_MedianContext context) { }

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
        /// Enter a parse tree produced by the <c>MathStatistic_Variance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Variance([NotNull] EveryGrammarParser.MathStatistic_VarianceContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Variance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Variance([NotNull] EveryGrammarParser.MathStatistic_VarianceContext context) { }

        /// <summary>
        /// Enter a parse tree produced by <see cref="EveryGrammarParser.expr_args"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterExpr_args([NotNull] EveryGrammarParser.Expr_argsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by <see cref="EveryGrammarParser.expr_args"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitExpr_args([NotNull] EveryGrammarParser.Expr_argsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArrayCreation_Empty</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArrayCreation_Empty([NotNull] EveryGrammarParser.ArrayCreation_EmptyContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArrayCreation_Empty</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArrayCreation_Empty([NotNull] EveryGrammarParser.ArrayCreation_EmptyContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArrayCreation</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArrayCreation([NotNull] EveryGrammarParser.ArrayCreationContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArrayCreation</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArrayCreation([NotNull] EveryGrammarParser.ArrayCreationContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Variable</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Variable([NotNull] EveryGrammarParser.Factor_VariableContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_ObjectVariables</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_ObjectVariables([NotNull] EveryGrammarParser.Factor_ObjectVariablesContext context) { }

        public void VisitTerminal(ITerminalNode node)
        { }

        public void VisitErrorNode(IErrorNode node)
        { }

        public void EnterEveryRule(ParserRuleContext ctx)
        { }

        public void ExitEveryRule(ParserRuleContext ctx)
        { }
    }
}