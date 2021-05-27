using Antlr4.Runtime.Misc;
using EveryParser.Compare;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

namespace EveryParser
{
    public partial class EveryGrammarCalculatorListener
    {
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
                SetErrorNodeFor_ExitFactor_DateTimeTerm();
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 1, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues) ||
                !ErrorCollector.CheckIsDateTime(context, childValues)
                )
            {
                SetErrorNodeFor_ExitFactor_DateTimeTerm();
                return;
            }

            Node.Value = Convert.ToDateTime(childValues[0]);
            Node = Node.Parent;
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
        /// Sets the value of the node and goes up to parent, if some error is done
        /// TODO add errors
        /// </summary>
        private void SetErrorNodeFor_ExitFactor_DateTimeTerm()
        {
            Node.Value = null;
            Node = Node.Parent;
        }

        /// <summary>
        /// Method to use in order to create the date value.
        /// Therefore the date methods are very similar, it's everything here inside one method
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expectedDateParameters"></param>
        private void SetNodeForDateTimeValue([NotNull] ParserRuleContext context, int expectedDateParameters)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                SetErrorNodeFor_ExitFactor_DateTimeTerm();
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();
            var childValuesLength = childValues.Length;

            if (!ErrorCollector.CheckParamsCount(context, expectedDateParameters, childValues) ||
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

    }
}
