using Antlr4.Runtime.Misc;
using EveryParser.LinQReplaces;
using System;
using System.Collections.Generic;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

namespace EveryParser.CalculatorListener
{
    public partial class EveryGrammarCalculatorListener
    {
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

            if (!ErrorCollector.CheckParamsCount(context, expectedDateParameters, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues) ||
                !ErrorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
            {
                SetErrorNodeFor_ExitFactor_DateTimeTerm();
                return;
            }

            var date = new DateTime();
            var dateList = new List<DateTime>();
            for (var datePartIndex = 0; datePartIndex < childValues.Length; datePartIndex++)
            {
                var datePartList = childValues[datePartIndex] as List<object>;
                var datePart = -1;
                if (datePartList is null)
                    datePart = Convert.ToInt32(childValues[datePartIndex]);

                Func<DateTime, int, DateTime> expression;

                switch (datePartIndex)
                {
                    case 0:
                        expression = (d, v) => d.AddYears(v - d.Year);
                        break;

                    case 1:
                        expression = (d, v) => d.AddMonths(v - d.Month);
                        break;

                    case 2:
                        expression = (d, v) => d.AddDays(v - d.Day);
                        break;

                    case 3:
                        expression = (d, v) => d.AddHours(v - d.Hour);
                        break;

                    case 4:
                        expression = (d, v) => d.AddMinutes(v - d.Minute);
                        break;

                    case 5:
                        expression = (d, v) => d.AddSeconds(v - d.Second);
                        break;

                    case 6:
                        expression = (d, v) => d.AddMilliseconds(v - d.Millisecond);
                        break;

                    default:
                        SetErrorNodeFor_ExitFactor_DateTimeTerm();
                        return;
                }

                var result = GetDateTimeResult(context, date, dateList, datePart, datePartList, expression);

                if (!result.result)
                {
                    SetErrorNodeFor_ExitFactor_DateTimeTerm();
                    return;
                }

                date = result.dateResult;
                dateList = result.dateResultList;
            }

            Node.Value = date;
            Node = Node.Parent;
        }

        private (bool result, DateTime dateResult, List<DateTime> dateResultList) GetDateTimeResult(ParserRuleContext context, DateTime currentDate,
            List<DateTime> currentDateList, int value, List<object> valueList, Func<DateTime, int, DateTime> expression)
        {
            if (valueList is null)
            {
                if (currentDateList.Any())
                    currentDateList = currentDateList.Select(d => expression.Invoke(d, value));
                else
                    currentDate = expression.Invoke(currentDate, value);
            }
            else
            {
                if (currentDateList.Count != 0 && currentDateList.Count != valueList.Count)
                {
                    ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, "Count of arrays are not equal!");
                    return (false, DateTime.MinValue, null);
                }

                var result = new List<DateTime>();
                for (int i = 0; i < valueList.Count; i += 1)
                {
                    var d = currentDateList.Count == 0 ? currentDate : currentDateList[i];
                    result.Add(expression.Invoke(d, Convert.ToInt32(valueList[i])));
                }
                currentDateList = result;
            }

            return (true, currentDate, currentDateList);
        }
    }
}