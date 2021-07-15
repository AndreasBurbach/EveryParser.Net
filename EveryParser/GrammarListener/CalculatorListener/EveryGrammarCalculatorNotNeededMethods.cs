using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace EveryParser.CalculatorListener
{
    public partial class EveryGrammarCalculatorListener
    {
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
        /// Enter a parse tree produced by the <c>BoolXOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_xor_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterBoolXOr_Next([NotNull] EveryGrammarParser.BoolXOr_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolXOr_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_xor_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitBoolXOr_Next([NotNull] EveryGrammarParser.BoolXOr_NextContext context) { }

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
        /// Enter a parse tree produced by the <c>Factor_Brackets</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Brackets([NotNull] EveryGrammarParser.Factor_BracketsContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Brackets</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Brackets([NotNull] EveryGrammarParser.Factor_BracketsContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterPointTerm_Next([NotNull] EveryGrammarParser.PointTerm_NextContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Next</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitPointTerm_Next([NotNull] EveryGrammarParser.PointTerm_NextContext context) { }

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
        /// Exit a parse tree produced by the <c>ArrayCreation_Empty</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArrayCreation_Empty([NotNull] EveryGrammarParser.ArrayCreation_EmptyContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_String</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_String([NotNull] EveryGrammarParser.Factor_StringContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_ObjectVariables</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_ObjectVariables([NotNull] EveryGrammarParser.Factor_ObjectVariablesContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Variable</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Variable([NotNull] EveryGrammarParser.Factor_VariableContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Double</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Double([NotNull] EveryGrammarParser.Factor_DoubleContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Integer([NotNull] EveryGrammarParser.Factor_IntegerContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_False</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_False([NotNull] EveryGrammarParser.Factor_FalseContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_True</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_True([NotNull] EveryGrammarParser.Factor_TrueContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Not</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Not([NotNull] EveryGrammarParser.Factor_NotContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Indexing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Indexing([NotNull] EveryGrammarParser.ArraySlicing_IndexingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Slicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Slicing([NotNull] EveryGrammarParser.ArraySlicing_SlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StepSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StartSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StartSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StartStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StartStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartStepSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_EndSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_EndSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_EndStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_EndStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndStepSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_AllStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_AllStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_AllStepSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_Decimal([NotNull] EveryGrammarParser.Random_DecimalContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_Integer([NotNull] EveryGrammarParser.Random_IntegerContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_DateTimeTerm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_DateTimeTerm([NotNull] EveryGrammarParser.Factor_DateTimeTermContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_DateTimeTerm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_DateTimeTerm([NotNull] EveryGrammarParser.Factor_DateTimeTermContext context) { }
    }
}