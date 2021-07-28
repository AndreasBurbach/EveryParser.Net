namespace EveryParser.GrammarListener.TypeListener
{
    using Antlr4.Runtime.Misc;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class provides an empty implementation of <see cref="IEveryGrammarListener"/>,
    /// which can be extended to create a listener which only needs to handle a subset
    /// of the available methods.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
    public partial class EveryGrammarTypeListener : IEveryGrammarListener
    {
        internal TypeNode Node;
        private EveryParserType _result = EveryParserType.None;
        private SortedList<string, object> _arguments;
        private ArraySlicingType _lastArraySlicingType;

        public ErrorCollector ErrorCollector;

        public EveryParserType Result => _result;

        public EveryGrammarTypeListener(SortedList<string, object> arguments)
        {
            _arguments = arguments;
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="EveryGrammarParser.startRule"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterStartRule([NotNull] EveryGrammarParser.StartRuleContext context)
        {
            Node = new TypeNode();
            ErrorCollector = new ErrorCollector();
            _result = EveryParserType.None;
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="EveryGrammarParser.startRule"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitStartRule([NotNull] EveryGrammarParser.StartRuleContext context)
        {
            _result = Node.Children[0].ValueType;
        }

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
        /// Enter a parse tree produced by the <c>BoolOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolOr([NotNull] EveryGrammarParser.BoolOrContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolOr([NotNull] EveryGrammarParser.BoolOrContext context)
        {
            CalcBooleanOrBooleanArrayBinary(context, EveryParserType.Boolean, EveryParserType.ArrayOfBoolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolXOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_xor_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolXOr([NotNull] EveryGrammarParser.BoolXOrContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolXOr</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_xor_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolXOr([NotNull] EveryGrammarParser.BoolXOrContext context)
        {
            CalcBooleanOrBooleanArrayBinary(context, EveryParserType.Boolean, EveryParserType.ArrayOfBoolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>BoolAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBoolAnd([NotNull] EveryGrammarParser.BoolAndContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>BoolAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bool_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBoolAnd([NotNull] EveryGrammarParser.BoolAndContext context)
        {
            CalcBooleanOrBooleanArrayBinary(context, EveryParserType.Boolean, EveryParserType.ArrayOfBoolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_Contains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_Contains([NotNull] EveryGrammarParser.Equality_ContainsContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_Contains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_Contains([NotNull] EveryGrammarParser.Equality_ContainsContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (Node.Children[0].ValueType == EveryParserType.None)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "First Parameter has no type!");
                else if (!Node.Children[1].ValueType.IsArrayType() && !Node.Children[1].ValueType.IsString())
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "Second Parameter is not an array or string!");
                else
                    Node.ValueType = EveryParserType.Boolean;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_Equal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_Equal([NotNull] EveryGrammarParser.Equality_EqualContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_Equal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_Equal([NotNull] EveryGrammarParser.Equality_EqualContext context)
        {
            CheckAnyBinary(context, EveryParserType.Boolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_NotEqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_NotEqualIgnoreCase([NotNull] EveryGrammarParser.Equality_NotEqualIgnoreCaseContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_NotEqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_NotEqualIgnoreCase([NotNull] EveryGrammarParser.Equality_NotEqualIgnoreCaseContext context)
        {
            CheckStringOrArrayOfStringsBinary(context, EveryParserType.Boolean, EveryParserType.Boolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_NotEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_NotEqual([NotNull] EveryGrammarParser.Equality_NotEqualContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_NotEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_NotEqual([NotNull] EveryGrammarParser.Equality_NotEqualContext context)
        {
            CheckAnyBinary(context, EveryParserType.Boolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_NotContains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_NotContains([NotNull] EveryGrammarParser.Equality_NotContainsContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_NotContains</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_NotContains([NotNull] EveryGrammarParser.Equality_NotContainsContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (Node.Children[0].ValueType == EveryParserType.None)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "First Parameter has no type!");
                else if (!Node.Children[1].ValueType.IsArrayType() && !Node.Children[1].ValueType.IsString())
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "Second Parameter is not an array or string!");
                else
                    Node.ValueType = EveryParserType.Boolean;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Equality_EqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterEquality_EqualIgnoreCase([NotNull] EveryGrammarParser.Equality_EqualIgnoreCaseContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Equality_EqualIgnoreCase</c>
        /// labeled alternative in <see cref="EveryGrammarParser.equality"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitEquality_EqualIgnoreCase([NotNull] EveryGrammarParser.Equality_EqualIgnoreCaseContext context)
        {
            CheckStringOrArrayOfStringsBinary(context, EveryParserType.Boolean, EveryParserType.Boolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_Greater</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_Greater([NotNull] EveryGrammarParser.Check_GreaterContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_Greater</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_Greater([NotNull] EveryGrammarParser.Check_GreaterContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context, EveryParserType.Boolean, EveryParserType.ArrayOfBoolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_GreaterEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_GreaterEqual([NotNull] EveryGrammarParser.Check_GreaterEqualContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_GreaterEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_GreaterEqual([NotNull] EveryGrammarParser.Check_GreaterEqualContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context, EveryParserType.Boolean, EveryParserType.ArrayOfBoolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_Lower([NotNull] EveryGrammarParser.Check_LowerContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_Lower([NotNull] EveryGrammarParser.Check_LowerContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context, EveryParserType.Boolean, EveryParserType.ArrayOfBoolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Check_LowerEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheck_LowerEqual([NotNull] EveryGrammarParser.Check_LowerEqualContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Check_LowerEqual</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheck_LowerEqual([NotNull] EveryGrammarParser.Check_LowerEqualContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context, EveryParserType.Boolean, EveryParserType.ArrayOfBoolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitOR</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitOR([NotNull] EveryGrammarParser.BitORContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitOR</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_or_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitOR([NotNull] EveryGrammarParser.BitORContext context)
        {
            CheckNumericBinary(context, EveryParserType.Number);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>BitAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterBitAnd([NotNull] EveryGrammarParser.BitAndContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>BitAnd</c>
        /// labeled alternative in <see cref="EveryGrammarParser.bit_and_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitBitAnd([NotNull] EveryGrammarParser.BitAndContext context)
        {
            CheckNumericBinary(context, EveryParserType.Number);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Line_Addition</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterLine_Addition([NotNull] EveryGrammarParser.Line_AdditionContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Line_Addition</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitLine_Addition([NotNull] EveryGrammarParser.Line_AdditionContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Line_Subtraction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterLine_Subtraction([NotNull] EveryGrammarParser.Line_SubtractionContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Line_Subtraction</c>
        /// labeled alternative in <see cref="EveryGrammarParser.line_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitLine_Subtraction([NotNull] EveryGrammarParser.Line_SubtractionContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_PowerOperator</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_PowerOperator([NotNull] EveryGrammarParser.PointTerm_PowerOperatorContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_PowerOperator</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_PowerOperator([NotNull] EveryGrammarParser.PointTerm_PowerOperatorContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Modulo</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Modulo([NotNull] EveryGrammarParser.PointTerm_ModuloContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Modulo</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Modulo([NotNull] EveryGrammarParser.PointTerm_ModuloContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Multiply</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Multiply([NotNull] EveryGrammarParser.PointTerm_MultiplyContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Multiply</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Multiply([NotNull] EveryGrammarParser.PointTerm_MultiplyContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_BitShiftLeft</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_BitShiftLeft([NotNull] EveryGrammarParser.PointTerm_BitShiftLeftContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_BitShiftLeft</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_BitShiftLeft([NotNull] EveryGrammarParser.PointTerm_BitShiftLeftContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_IntegerDivision</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_IntegerDivision([NotNull] EveryGrammarParser.PointTerm_IntegerDivisionContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_IntegerDivision</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_IntegerDivision([NotNull] EveryGrammarParser.PointTerm_IntegerDivisionContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_BitShiftRight</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_BitShiftRight([NotNull] EveryGrammarParser.PointTerm_BitShiftRightContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_BitShiftRight</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_BitShiftRight([NotNull] EveryGrammarParser.PointTerm_BitShiftRightContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>PointTerm_Divide</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterPointTerm_Divide([NotNull] EveryGrammarParser.PointTerm_DivideContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>PointTerm_Divide</c>
        /// labeled alternative in <see cref="EveryGrammarParser.point_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitPointTerm_Divide([NotNull] EveryGrammarParser.PointTerm_DivideContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Not</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Not([NotNull] EveryGrammarParser.Factor_NotContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Not</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Not([NotNull] EveryGrammarParser.Factor_NotContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                if (Node.Children[0].ValueType != EveryParserType.Boolean)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter is not a boolean!");
                else
                    Node.ValueType = EveryParserType.Boolean;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Minus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Minus([NotNull] EveryGrammarParser.Factor_MinusContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Minus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Minus([NotNull] EveryGrammarParser.Factor_MinusContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Plus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Plus([NotNull] EveryGrammarParser.Factor_PlusContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Plus</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Plus([NotNull] EveryGrammarParser.Factor_PlusContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Tilde</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Tilde([NotNull] EveryGrammarParser.Factor_TildeContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Tilde</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Tilde([NotNull] EveryGrammarParser.Factor_TildeContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Factorial</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Factorial([NotNull] EveryGrammarParser.Factor_FactorialContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Factorial</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Factorial([NotNull] EveryGrammarParser.Factor_FactorialContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_True</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_True([NotNull] EveryGrammarParser.Factor_TrueContext context)
        {
            Node.AddChildNode(EveryParserType.Boolean);
        }

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
        public void EnterFactor_False([NotNull] EveryGrammarParser.Factor_FalseContext context)
        {
            Node.AddChildNode(EveryParserType.Boolean);
        }

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
        public void EnterFactor_Integer([NotNull] EveryGrammarParser.Factor_IntegerContext context)
        {
            Node.AddChildNode(EveryParserType.Number);
        }

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
        public void EnterFactor_Double([NotNull] EveryGrammarParser.Factor_DoubleContext context)
        {
            Node.AddChildNode(EveryParserType.Number);
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Double</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Double([NotNull] EveryGrammarParser.Factor_DoubleContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Variable</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Variable([NotNull] EveryGrammarParser.Factor_VariableContext context)
        {
            string text = context.GetText();
            EveryParserType type = EveryParserType.None;

            if (text.Equals("e", StringComparison.InvariantCultureIgnoreCase) || text.Equals("pi", StringComparison.InvariantCultureIgnoreCase))
                type = EveryParserType.Number;
            else
            {
                var value = ErrorCollector.GetCheckedArgument(context, _arguments, text);

                if (value is IEnumerable<string>)
                    type = EveryParserType.ArrayOfString;
                else if (value is IEnumerable<decimal> || value is IEnumerable<byte> || value is IEnumerable<int> ||
                    value is IEnumerable<double> || value is IEnumerable<float> || value is IEnumerable<short>)
                    type = EveryParserType.ArrayOfNumber;
                else if (value is IEnumerable<char>)
                    type = EveryParserType.ArrayOfString;
                else if (value is IEnumerable<bool>)
                    type = EveryParserType.ArrayOfBoolean;
                else if (value is IEnumerable<DateTime>)
                    type = EveryParserType.ArrayOfDateTime;
                else if (TypeCheckHelper.IsBoolean(value))
                    type = EveryParserType.Boolean;
                else if (TypeCheckHelper.IsNumber(value))
                    type = EveryParserType.Number;
                else if (value is string)
                    type = EveryParserType.String;
                else if (value is DateTime)
                    type = EveryParserType.DateTime;
            }

            Node.AddChildNode(type);
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_Variable</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_Variable([NotNull] EveryGrammarParser.Factor_VariableContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_ObjectVariables</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_ObjectVariables([NotNull] EveryGrammarParser.Factor_ObjectVariablesContext context)
        {
            string text = context.GetText();
            EveryParserType type = EveryParserType.None;

            if (text.Equals("DateTime.Now", StringComparison.InvariantCultureIgnoreCase))
                type = EveryParserType.DateTime;
            else
            {
                var value = ErrorCollector.GetCheckedObjectArgument(context, _arguments, text);

                if (value is IEnumerable<string>)
                    type = EveryParserType.ArrayOfString;
                else if (value is IEnumerable<decimal> || value is IEnumerable<byte> || value is IEnumerable<int> ||
                    value is IEnumerable<double> || value is IEnumerable<float> || value is IEnumerable<short>)
                    type = EveryParserType.ArrayOfNumber;
                else if (value is IEnumerable<char>)
                    type = EveryParserType.ArrayOfString;
                else if (value is IEnumerable<bool>)
                    type = EveryParserType.ArrayOfBoolean;
                else if (value is IEnumerable<DateTime>)
                    type = EveryParserType.ArrayOfDateTime;
                else if (TypeCheckHelper.IsBoolean(value))
                    type = EveryParserType.Boolean;
                else if (TypeCheckHelper.IsNumber(value))
                    type = EveryParserType.Number;
                else if (value is string)
                    type = EveryParserType.String;
                else if (value is DateTime)
                    type = EveryParserType.DateTime;
            }

            Node.AddChildNode(type);
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_ObjectVariables</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_ObjectVariables([NotNull] EveryGrammarParser.Factor_ObjectVariablesContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_String</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_String([NotNull] EveryGrammarParser.Factor_StringContext context)
        {
            Node.AddChildNode(EveryParserType.String);
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Factor_String</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFactor_String([NotNull] EveryGrammarParser.Factor_StringContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_Decimal([NotNull] EveryGrammarParser.Random_DecimalContext context)
        {
            Node.AddChildNode(EveryParserType.Number);
        }

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
        public void EnterRandom_DecimalArray([NotNull] EveryGrammarParser.Random_DecimalArrayContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_DecimalArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_DecimalArray([NotNull] EveryGrammarParser.Random_DecimalArrayContext context)
        {
            CheckNumericUnary(context, EveryParserType.ArrayOfNumber);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_DecimalMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_DecimalMinMax([NotNull] EveryGrammarParser.Random_DecimalMinMaxContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_DecimalMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_DecimalMinMax([NotNull] EveryGrammarParser.Random_DecimalMinMaxContext context)
        {
            CheckNumericBinary(context, EveryParserType.Number);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_DecimalArrayMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_DecimalArrayMinMax([NotNull] EveryGrammarParser.Random_DecimalArrayMinMaxContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_DecimalArrayMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_DecimalArrayMinMax([NotNull] EveryGrammarParser.Random_DecimalArrayMinMaxContext context)
        {
            CheckNumericTri(context, EveryParserType.ArrayOfNumber);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_Integer([NotNull] EveryGrammarParser.Random_IntegerContext context)
        {
            Node.AddChildNode(EveryParserType.Number);
        }

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
        public void EnterRandom_IntegerArray([NotNull] EveryGrammarParser.Random_IntegerArrayContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_IntegerArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_IntegerArray([NotNull] EveryGrammarParser.Random_IntegerArrayContext context)
        {
            CheckNumericUnary(context, EveryParserType.ArrayOfNumber);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_IntegerMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_IntegerMinMax([NotNull] EveryGrammarParser.Random_IntegerMinMaxContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_IntegerMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_IntegerMinMax([NotNull] EveryGrammarParser.Random_IntegerMinMaxContext context)
        {
            CheckNumericBinary(context, EveryParserType.Number);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_IntegerArrayMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_IntegerArrayMinMax([NotNull] EveryGrammarParser.Random_IntegerArrayMinMaxContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Random_IntegerArrayMinMax</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitRandom_IntegerArrayMinMax([NotNull] EveryGrammarParser.Random_IntegerArrayMinMaxContext context)
        {
            CheckNumericTri(context, EveryParserType.ArrayOfNumber);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_ToArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_ToArray([NotNull] EveryGrammarParser.Convert_ToArrayContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_ToArray</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_ToArray([NotNull] EveryGrammarParser.Convert_ToArrayContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                var type = Node.Children[0].ValueType;

                if (type.IsArrayType())
                    Node.ValueType = type;
                else if (type.IsString())
                    Node.ValueType = EveryParserType.ArrayOfString;
                else if (type.IsNumber())
                    Node.ValueType = EveryParserType.ArrayOfNumber;
                else if (type.IsBoolean())
                    Node.ValueType = EveryParserType.ArrayOfBoolean;
                else if (type.IsDateTime())
                    Node.ValueType = EveryParserType.ArrayOfDateTime;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_ToBoolean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_ToBoolean([NotNull] EveryGrammarParser.Convert_ToBooleanContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_ToBoolean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_ToBoolean([NotNull] EveryGrammarParser.Convert_ToBooleanContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                var type = Node.Children[0].ValueType;

                if (type.IsArrayType() || type.IsBoolean() || type.IsString() || type.IsNumber())
                    Node.ValueType = EveryParserType.Boolean;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_ToNumber</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_ToNumber([NotNull] EveryGrammarParser.Convert_ToNumberContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_ToNumber</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_ToNumber([NotNull] EveryGrammarParser.Convert_ToNumberContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                var type = Node.Children[0].ValueType;

                if (type.IsNumber() || type.IsBoolean() || type.IsString())
                    Node.ValueType = EveryParserType.Number;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_ToString</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_ToString([NotNull] EveryGrammarParser.Convert_ToStringContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_ToString</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_ToString([NotNull] EveryGrammarParser.Convert_ToStringContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
                Node.ValueType = EveryParserType.String;

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_DegreeToGrad</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_DegreeToGrad([NotNull] EveryGrammarParser.Convert_DegreeToGradContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_DegreeToGrad</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_DegreeToGrad([NotNull] EveryGrammarParser.Convert_DegreeToGradContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_DegreeToRadian</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_DegreeToRadian([NotNull] EveryGrammarParser.Convert_DegreeToRadianContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_DegreeToRadian</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_DegreeToRadian([NotNull] EveryGrammarParser.Convert_DegreeToRadianContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_GradToDegree</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_GradToDegree([NotNull] EveryGrammarParser.Convert_GradToDegreeContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_GradToDegree</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_GradToDegree([NotNull] EveryGrammarParser.Convert_GradToDegreeContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_GradToRadian</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_GradToRadian([NotNull] EveryGrammarParser.Convert_GradToRadianContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_GradToRadian</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_GradToRadian([NotNull] EveryGrammarParser.Convert_GradToRadianContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_RadianToDegree</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_RadianToDegree([NotNull] EveryGrammarParser.Convert_RadianToDegreeContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_RadianToDegree</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_RadianToDegree([NotNull] EveryGrammarParser.Convert_RadianToDegreeContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_RadianToGrad</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_RadianToGrad([NotNull] EveryGrammarParser.Convert_RadianToGradContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_RadianToGrad</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_RadianToGrad([NotNull] EveryGrammarParser.Convert_RadianToGradContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

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
            SetNodeForDateTimeValue(context, 1);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateEntry</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateEntry([NotNull] EveryGrammarParser.DateTime_DateEntryContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateEntry</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateEntry([NotNull] EveryGrammarParser.DateTime_DateEntryContext context)
        {
            SetNodeForDateTimeValue(context, 3);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateHour</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateHour([NotNull] EveryGrammarParser.DateTime_DateHourContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateHour</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateHour([NotNull] EveryGrammarParser.DateTime_DateHourContext context)
        {
            SetNodeForDateTimeValue(context, 4);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateHourMinute</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateHourMinute([NotNull] EveryGrammarParser.DateTime_DateHourMinuteContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateHourMinute</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateHourMinute([NotNull] EveryGrammarParser.DateTime_DateHourMinuteContext context)
        {
            SetNodeForDateTimeValue(context, 5);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_DateHourMinuteSeconds</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_DateHourMinuteSeconds([NotNull] EveryGrammarParser.DateTime_DateHourMinuteSecondsContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_DateHourMinuteSeconds</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_DateHourMinuteSeconds([NotNull] EveryGrammarParser.DateTime_DateHourMinuteSecondsContext context)
        {
            SetNodeForDateTimeValue(context, 6);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>DateTime_Full</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterDateTime_Full([NotNull] EveryGrammarParser.DateTime_FullContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>DateTime_Full</c>
        /// labeled alternative in <see cref="EveryGrammarParser.datetime_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitDateTime_Full([NotNull] EveryGrammarParser.DateTime_FullContext context)
        {
            SetNodeForDateTimeValue(context, 7);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing([NotNull] EveryGrammarParser.ArraySlicingContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing([NotNull] EveryGrammarParser.ArraySlicingContext context)
        {
            ArraySlicing(context, _lastArraySlicingType);
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Indexing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Indexing([NotNull] EveryGrammarParser.ArraySlicing_IndexingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.Indexing;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_StartSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_StartSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartSlicingContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Slicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Slicing([NotNull] EveryGrammarParser.ArraySlicing_SlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.Slicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StepSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.StepSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StartSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StartSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.StartSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StartStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StartStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartStepSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.StartStepSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_EndSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_EndSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.EndSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_EndStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_EndStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndStepSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.EndStepSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_AllStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_AllStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_AllStepSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.AllStepSlicing;
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
            CheckAnyUnary(context, EveryParserType.Boolean);
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
            CheckAnyUnary(context, EveryParserType.Boolean);
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
            CheckAnyUnary(context, EveryParserType.Boolean);
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
            CheckAnyUnary(context, EveryParserType.Boolean);
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
            CheckAnyUnary(context, EveryParserType.Boolean);
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
            CheckAnyUnary(context, EveryParserType.Boolean);
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
            CheckStringOrArrayOfStringsUnary(context, EveryParserType.Boolean, EveryParserType.Boolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_HasAny</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_HasAny([NotNull] EveryGrammarParser.CheckFunction_HasAnyContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_HasAny</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_HasAny([NotNull] EveryGrammarParser.CheckFunction_HasAnyContext context)
        {
            CheckStringOrListUnary(context, EveryParserType.Boolean, EveryParserType.Boolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>CheckFunction_HasDuplicates</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterCheckFunction_HasDuplicates([NotNull] EveryGrammarParser.CheckFunction_HasDuplicatesContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>CheckFunction_HasDuplicates</c>
        /// labeled alternative in <see cref="EveryGrammarParser.check_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitCheckFunction_HasDuplicates([NotNull] EveryGrammarParser.CheckFunction_HasDuplicatesContext context)
        {
            CheckStringOrListUnary(context, EveryParserType.Boolean, EveryParserType.Boolean);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Concat</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Concat([NotNull] EveryGrammarParser.Function_ConcatContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Concat</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Concat([NotNull] EveryGrammarParser.Function_ConcatContext context)
        {
            CheckOnlyStringOrOnlyArraySameResult(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Count</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Count([NotNull] EveryGrammarParser.Function_CountContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Count</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Count([NotNull] EveryGrammarParser.Function_CountContext context)
        {
            CheckStringOrListUnary(context, EveryParserType.Number, EveryParserType.Number);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Distinc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Distinc([NotNull] EveryGrammarParser.Function_DistincContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Distinc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Distinc([NotNull] EveryGrammarParser.Function_DistincContext context)
        {
            CheckStringOrListUnary(context, EveryParserType.String, EveryParserType.Array);
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
            CheckOnlyStringOrOnlyArraySameResult(context);
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
            CheckOnlyStringOrOnlyArraySameResult(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_IndexOf</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_IndexOf([NotNull] EveryGrammarParser.Function_IndexOfContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_IndexOf</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_IndexOf([NotNull] EveryGrammarParser.Function_IndexOfContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                var type1 = Node.Children[0].ValueType;

                if (!type1.IsString() && !type1.IsArrayType())
                    ErrorCollector.AddError(context, ErrorCode.FirstIsNotArray, "First parameter must be a string or an Array");
                else
                    Node.ValueType = EveryParserType.Number;
            }

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
            if (ErrorCollector.CheckParamsCount(context, 3, Node.Children))
            {
                var type1 = Node.Children[0].ValueType;
                var type3 = Node.Children[2].ValueType;

                if (!type1.IsString() && !type1.IsArrayType())
                    ErrorCollector.AddError(context, ErrorCode.FirstIsNotArray, "First parameter must be a string or an Array");
                else if (!type3.IsNumber())
                    ErrorCollector.AddError(context, ErrorCode.ThridNotNumber, "Third parameter must be a number");
                else
                    Node.ValueType = EveryParserType.Number;
            }

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
            if (ErrorCollector.CheckParamsCount(context, 4, Node.Children))
            {
                var type1 = Node.Children[0].ValueType;
                var type3 = Node.Children[2].ValueType;
                var type4 = Node.Children[3].ValueType;

                if (!type1.IsString() && !type1.IsArrayType())
                    ErrorCollector.AddError(context, ErrorCode.FirstIsNotArray, "First parameter must be a string or an Array");
                else if (!type3.IsNumber())
                    ErrorCollector.AddError(context, ErrorCode.ThridNotNumber, "Third parameter must be a number");
                else if (!type4.IsNumber())
                    ErrorCollector.AddError(context, ErrorCode.ForthNotNumber, "Forth parameter must be a number");
                else
                    Node.ValueType = EveryParserType.Number;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Lower([NotNull] EveryGrammarParser.Function_LowerContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Lower</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Lower([NotNull] EveryGrammarParser.Function_LowerContext context)
        {
            CheckStringOrArrayOfStringsUnary(context, EveryParserType.String, EveryParserType.ArrayOfString);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Reverse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Reverse([NotNull] EveryGrammarParser.Function_ReverseContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Reverse</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Reverse([NotNull] EveryGrammarParser.Function_ReverseContext context)
        {
            CheckStringOrListUnary(context, EveryParserType.String, EveryParserType.Array);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Function_Upper</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFunction_Upper([NotNull] EveryGrammarParser.Function_UpperContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Function_Upper</c>
        /// labeled alternative in <see cref="EveryGrammarParser.default_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitFunction_Upper([NotNull] EveryGrammarParser.Function_UpperContext context)
        {
            CheckStringOrArrayOfStringsUnary(context, EveryParserType.String, EveryParserType.ArrayOfString);
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
            CheckStringOrListUnary(context, EveryParserType.String, EveryParserType.Array);
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
            CheckStringOrListUnary(context, EveryParserType.String, EveryParserType.Array);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Abs</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Abs([NotNull] EveryGrammarParser.Math_AbsContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Abs</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Abs([NotNull] EveryGrammarParser.Math_AbsContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACos([NotNull] EveryGrammarParser.Math_ACosContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACos([NotNull] EveryGrammarParser.Math_ACosContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACosH([NotNull] EveryGrammarParser.Math_ACosHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACosH([NotNull] EveryGrammarParser.Math_ACosHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASin([NotNull] EveryGrammarParser.Math_ASinContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASin([NotNull] EveryGrammarParser.Math_ASinContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASinH([NotNull] EveryGrammarParser.Math_ASinHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASinH([NotNull] EveryGrammarParser.Math_ASinHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ATan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ATan([NotNull] EveryGrammarParser.Math_ATanContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ATan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ATan([NotNull] EveryGrammarParser.Math_ATanContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ATan2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ATan2([NotNull] EveryGrammarParser.Math_ATan2Context context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ATan2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ATan2([NotNull] EveryGrammarParser.Math_ATan2Context context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ATanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ATanH([NotNull] EveryGrammarParser.Math_ATanHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ATanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ATanH([NotNull] EveryGrammarParser.Math_ATanHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Cbrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Cbrt([NotNull] EveryGrammarParser.Math_CbrtContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Cbrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Cbrt([NotNull] EveryGrammarParser.Math_CbrtContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Cos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Cos([NotNull] EveryGrammarParser.Math_CosContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Cos</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Cos([NotNull] EveryGrammarParser.Math_CosContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CosH([NotNull] EveryGrammarParser.Math_CosHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CosH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CosH([NotNull] EveryGrammarParser.Math_CosHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Ceilling</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Ceilling([NotNull] EveryGrammarParser.Math_CeillingContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Ceilling</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Ceilling([NotNull] EveryGrammarParser.Math_CeillingContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Clamp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Clamp([NotNull] EveryGrammarParser.Math_ClampContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Clamp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Clamp([NotNull] EveryGrammarParser.Math_ClampContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 3, Node.Children))
            {
                var type1 = Node.Children[0].ValueType;
                var type2 = Node.Children[1].ValueType;
                var type3 = Node.Children[2].ValueType;

                if ((!type1.IsNumberArray() && !type1.IsNumber()) || (!type2.IsNumberArray() && !type2.IsNumber()) || (!type3.IsNumberArray() && !type3.IsNumber()))
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "One or more parameters are not Numbers or Array of Numbers!");
                else if (type1.IsNumberArray() || type2.IsNumberArray() || type3.IsNumberArray())
                    Node.ValueType = EveryParserType.ArrayOfNumber;
                else
                    Node.ValueType = EveryParserType.Number;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CrossSum</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CrossSum([NotNull] EveryGrammarParser.Math_CrossSumContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CrossSum</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CrossSum([NotNull] EveryGrammarParser.Math_CrossSumContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Derivative</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Derivative([NotNull] EveryGrammarParser.Math_DerivativeContext context)
        {
            Node = Node.AddChildNode();
        }

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
        public void EnterMath_Exp([NotNull] EveryGrammarParser.Math_ExpContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Exp</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Exp([NotNull] EveryGrammarParser.Math_ExpContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Floor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Floor([NotNull] EveryGrammarParser.Math_FloorContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Floor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Floor([NotNull] EveryGrammarParser.Math_FloorContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Integration</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Integration([NotNull] EveryGrammarParser.Math_IntegrationContext context)
        {
            Node = Node.AddChildNode();
        }

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
        public void EnterMath_Log([NotNull] EveryGrammarParser.Math_LogContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Log</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Log([NotNull] EveryGrammarParser.Math_LogContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Log2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Log2([NotNull] EveryGrammarParser.Math_Log2Context context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Log2</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Log2([NotNull] EveryGrammarParser.Math_Log2Context context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Log10</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Log10([NotNull] EveryGrammarParser.Math_Log10Context context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Log10</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Log10([NotNull] EveryGrammarParser.Math_Log10Context context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Max_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Max_Array([NotNull] EveryGrammarParser.Math_Max_ArrayContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Max_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Max_Array([NotNull] EveryGrammarParser.Math_Max_ArrayContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context, EveryParserType.Number, EveryParserType.Number, EveryParserType.None);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Max_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Max_Two([NotNull] EveryGrammarParser.Math_Max_TwoContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Max_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Max_Two([NotNull] EveryGrammarParser.Math_Max_TwoContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Min_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Min_Array([NotNull] EveryGrammarParser.Math_Min_ArrayContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Min_Array</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Min_Array([NotNull] EveryGrammarParser.Math_Min_ArrayContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context, EveryParserType.Number, EveryParserType.Number, EveryParserType.None);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Min_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Min_Two([NotNull] EveryGrammarParser.Math_Min_TwoContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Min_Two</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Min_Two([NotNull] EveryGrammarParser.Math_Min_TwoContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Power</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Power([NotNull] EveryGrammarParser.Math_PowerContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Power</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Power([NotNull] EveryGrammarParser.Math_PowerContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Round_Not_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Round_Not_Decimal([NotNull] EveryGrammarParser.Math_Round_Not_DecimalContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Round_Not_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Round_Not_Decimal([NotNull] EveryGrammarParser.Math_Round_Not_DecimalContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Round_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Round_Decimal([NotNull] EveryGrammarParser.Math_Round_DecimalContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Round_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Round_Decimal([NotNull] EveryGrammarParser.Math_Round_DecimalContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Root</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Root([NotNull] EveryGrammarParser.Math_RootContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Root</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Root([NotNull] EveryGrammarParser.Math_RootContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Sin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Sin([NotNull] EveryGrammarParser.Math_SinContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Sin</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Sin([NotNull] EveryGrammarParser.Math_SinContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_SinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_SinH([NotNull] EveryGrammarParser.Math_SinHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_SinH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_SinH([NotNull] EveryGrammarParser.Math_SinHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Sqrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Sqrt([NotNull] EveryGrammarParser.Math_SqrtContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Sqrt</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Sqrt([NotNull] EveryGrammarParser.Math_SqrtContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Tan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Tan([NotNull] EveryGrammarParser.Math_TanContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Tan</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Tan([NotNull] EveryGrammarParser.Math_TanContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_TanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_TanH([NotNull] EveryGrammarParser.Math_TanHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_TanH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_TanH([NotNull] EveryGrammarParser.Math_TanHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Truncate</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Truncate([NotNull] EveryGrammarParser.Math_TruncateContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Truncate</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Truncate([NotNull] EveryGrammarParser.Math_TruncateContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Norm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Norm([NotNull] EveryGrammarParser.Math_NormContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Norm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Norm([NotNull] EveryGrammarParser.Math_NormContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (!Node.Children[0].ValueType.IsNumberArray())
                    ErrorCollector.AddError(context, ErrorCode.FirstNotNumberArray, "First parameter must be an Array");
                else if (!Node.Children[1].ValueType.IsNumber())
                    ErrorCollector.AddError(context, ErrorCode.SecondNotNumber, "Second parameter must be a number");
                else
                    Node.ValueType = EveryParserType.Number;
            }

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_EulerNorm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_EulerNorm([NotNull] EveryGrammarParser.Math_EulerNormContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_EulerNorm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_EulerNorm([NotNull] EveryGrammarParser.Math_EulerNormContext context)
        {
            CheckListOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_MaxNorm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_MaxNorm([NotNull] EveryGrammarParser.Math_MaxNormContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_MaxNorm</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_MaxNorm([NotNull] EveryGrammarParser.Math_MaxNormContext context)
        {
            CheckListOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_GreatesCommonDivisor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_GreatesCommonDivisor([NotNull] EveryGrammarParser.Math_GreatesCommonDivisorContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_GreatesCommonDivisor</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_GreatesCommonDivisor([NotNull] EveryGrammarParser.Math_GreatesCommonDivisorContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_LeastCommonMultiple</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_LeastCommonMultiple([NotNull] EveryGrammarParser.Math_LeastCommonMultipleContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_LeastCommonMultiple</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_LeastCommonMultiple([NotNull] EveryGrammarParser.Math_LeastCommonMultipleContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_DotProduct</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_DotProduct([NotNull] EveryGrammarParser.Math_DotProductContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_DotProduct</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_DotProduct([NotNull] EveryGrammarParser.Math_DotProductContext context)
        {
            CheckListOfNumbersBinary(context, EveryParserType.Number);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Binomila</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Binomila([NotNull] EveryGrammarParser.Math_BinomilaContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Binomila</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Binomila([NotNull] EveryGrammarParser.Math_BinomilaContext context)
        {
            CheckNumberOrArrayOfNumbersBinary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACot</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACot([NotNull] EveryGrammarParser.Math_ACotContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACot</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACot([NotNull] EveryGrammarParser.Math_ACotContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACotH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACotH([NotNull] EveryGrammarParser.Math_ACotHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACotH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACotH([NotNull] EveryGrammarParser.Math_ACotHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACsc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACsc([NotNull] EveryGrammarParser.Math_ACscContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACsc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACsc([NotNull] EveryGrammarParser.Math_ACscContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ACscH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ACscH([NotNull] EveryGrammarParser.Math_ACscHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ACscH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ACscH([NotNull] EveryGrammarParser.Math_ACscHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASec</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASec([NotNull] EveryGrammarParser.Math_ASecContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASec</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASec([NotNull] EveryGrammarParser.Math_ASecContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_ASecH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_ASecH([NotNull] EveryGrammarParser.Math_ASecHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_ASecH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_ASecH([NotNull] EveryGrammarParser.Math_ASecHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Cot</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Cot([NotNull] EveryGrammarParser.Math_CotContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Cot</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Cot([NotNull] EveryGrammarParser.Math_CotContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CotH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CotH([NotNull] EveryGrammarParser.Math_CotHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CotH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CotH([NotNull] EveryGrammarParser.Math_CotHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Csc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Csc([NotNull] EveryGrammarParser.Math_CscContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Csc</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Csc([NotNull] EveryGrammarParser.Math_CscContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_CscH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_CscH([NotNull] EveryGrammarParser.Math_CscHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_CscH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_CscH([NotNull] EveryGrammarParser.Math_CscHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Sec</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Sec([NotNull] EveryGrammarParser.Math_SecContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Sec</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Sec([NotNull] EveryGrammarParser.Math_SecContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_SecH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_SecH([NotNull] EveryGrammarParser.Math_SecHContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_SecH</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_SecH([NotNull] EveryGrammarParser.Math_SecHContext context)
        {
            CheckNumberOrArrayOfNumbersUnary(context);
        }

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
            CheckListOfNumbersBinary(context, EveryParserType.Number);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Mean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Mean([NotNull] EveryGrammarParser.MathStatistic_MeanContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Mean</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Mean([NotNull] EveryGrammarParser.MathStatistic_MeanContext context)
        {
            CheckListOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Median</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Median([NotNull] EveryGrammarParser.MathStatistic_MedianContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Median</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Median([NotNull] EveryGrammarParser.MathStatistic_MedianContext context)
        {
            CheckListOfNumbersUnary(context);
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
            CheckListOfNumbersBinary(context, EveryParserType.Number);
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
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (!Node.Children[0].ValueType.IsNumberArray())
                    ErrorCollector.AddError(context, ErrorCode.FirstNotNumberArray, "First parameter must be an Array");
                else if (!Node.Children[1].ValueType.IsNumber())
                    ErrorCollector.AddError(context, ErrorCode.SecondNotNumber, "Second parameter must be a number");
                else
                    Node.ValueType = EveryParserType.Number;
            }

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
            CheckListOfNumbersBinary(context, EveryParserType.Number);
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
            CheckListOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>MathStatistic_Variance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMathStatistic_Variance([NotNull] EveryGrammarParser.MathStatistic_VarianceContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>MathStatistic_Variance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.statistic_math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMathStatistic_Variance([NotNull] EveryGrammarParser.MathStatistic_VarianceContext context)
        {
            CheckListOfNumbersUnary(context);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArrayCreation_Empty</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_expr"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArrayCreation_Empty([NotNull] EveryGrammarParser.ArrayCreation_EmptyContext context)
        {
            Node.AddChildNode(EveryParserType.EmptyArray);
        }

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
            Node.ValueType = GetArrayType(Node.Children);
            Node = Node.Parent;
        }
    }
}