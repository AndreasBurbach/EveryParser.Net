﻿using Antlr4.Runtime.Misc;
using EveryParser.LinQReplaces;
using EveryParser.Types;
using System;
using System.Collections.Generic;

namespace EveryParser.GrammarListener.CalculatorListener
{
    public partial class EveryGrammarCalculatorListener
    {
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
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 1, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            object value = childValues[0];

            if (value is List<object>)
                Node.Value = value;
            else if (value is string sValue)
                Node.Value = sValue.Select(x => (object)x.ToString());
            else if (TypeCheckHelper.IsNumber(value) || TypeCheckHelper.IsBoolean(value) || TypeCheckHelper.IsDateTime(value))
                Node.Value = new List<object> { value };

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
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 1, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            object value = childValues[0];

            if (value is List<object> listValue)
                Node.Value = listValue.Any();
            else if (value is string sValue)
                Node.Value = !string.IsNullOrWhiteSpace(sValue);
            else if (TypeCheckHelper.IsNumber(value))
                Node.Value = new EPDecimal(value) > 0;
            else if (TypeCheckHelper.IsBoolean(value))
                Node.Value = value;

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
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 1, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            object value = childValues[0];

            if (value is List<object>)
                Node.Value = double.NaN;
            else if (TypeCheckHelper.IsNumber(value))
                Node.Value = new EPDecimal(value);
            else if (TypeCheckHelper.IsBoolean(value))
                Node.Value = Convert.ToBoolean(value) ? 1 : 0;
            else if (decimal.TryParse(value.ToString(), out var number))
                Node.Value = number;

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
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, 1, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            if (childValues[0] is List<object>)
                Node.Value = null;
            else
                Node.Value = childValues[0]?.ToString();

            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Convert_DegreeToGread</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterConvert_DegreeToGrad([NotNull] EveryGrammarParser.Convert_DegreeToGradContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>Convert_DegreeToGread</c>
        /// labeled alternative in <see cref="EveryGrammarParser.convert_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitConvert_DegreeToGrad([NotNull] EveryGrammarParser.Convert_DegreeToGradContext context)
        {
            static object calculation(object x)
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.DegreeToGrad(value);
            }
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            static object calculation(object x)
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.DegreeToRadian(value);
            }
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            static object calculation(object x)
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.GradToDegree(value);
            }
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            static object calculation(object x)
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.GradToRadian(value);
            }
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            static object calculation(object x)
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.RadianToDegree(value);
            }
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            static object calculation(object x)
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.RadianToGrad(value);
            }
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }
    }
}