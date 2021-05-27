using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EveryParser
{
    public partial class EveryGrammarCalculatorListener
    {
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
            Func<object, object, object> calculation = (x1, x2) => (object)Math.Atan2(Convert.ToDouble(x1), Convert.ToDouble(x2));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation.Invoke, Node.Children, true);
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
            Func<object, object, object> calculation = (x1, x2) => (object)Math.Log(Convert.ToDouble(x1), Convert.ToDouble(x2));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation.Invoke, Node.Children, true);
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
        public void ExitMath_Max_Array([NotNull] EveryGrammarParser.Math_Max_ArrayContext context)
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

            if (childValues[0] is List<object> list)
            {
                decimal max = decimal.MinValue;
                foreach (var value in list)
                    max = Math.Max(max, Convert.ToDecimal(value));
                Node.Value = max;
            }
            else
                Node.Value = Convert.ToDecimal(childValues[0]);

            Node = Node.Parent;
        }

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
            Func<object, object, object> calculation = (x1, x2) => (object)Math.Max(Convert.ToDouble(x1), Convert.ToDouble(x2));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation.Invoke, Node.Children);
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
        public void ExitMath_Min_Array([NotNull] EveryGrammarParser.Math_Min_ArrayContext context)
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

            if (childValues[0] is List<object> list)
            {
                decimal min = decimal.MaxValue;
                foreach (var value in list)
                    min = Math.Min(min, Convert.ToDecimal(value));
                Node.Value = min;
            }
            else
                Node.Value = Convert.ToDecimal(childValues[0]);

            Node = Node.Parent;
        }

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
            Func<object, object, object> calculation = (x1, x2) => (object)Math.Min(Convert.ToDouble(x1), Convert.ToDouble(x2));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation.Invoke, Node.Children);
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
            Func<object, object, object> calculation = (x1, x2) => (object)Math.Pow(Convert.ToDouble(x1), Convert.ToDouble(x2));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation.Invoke, Node.Children, true);
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
            Func<object, object, object> calculation = (x1, x2) => (object)Math.Round(Convert.ToDecimal(x1), Convert.ToInt32(x2));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation.Invoke, Node.Children, true);
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
            Func<object, object, object> calculation = (x1, x2) => (object)Math.Pow(Convert.ToDouble(x1), 1 / Convert.ToDouble(x2));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation.Invoke, Node.Children, true);
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
        /// Enter a parse tree produced by the <c>Math_Slope</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Slope([NotNull] EveryGrammarParser.Math_SlopeContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Slope</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Slope([NotNull] EveryGrammarParser.Math_SlopeContext context) { }

        /// <summary>
        /// Enter a parse tree produced by the <c>Math_Distance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterMath_Distance([NotNull] EveryGrammarParser.Math_DistanceContext context) { }

        /// <summary>
        /// Exit a parse tree produced by the <c>Math_Distance</c>
        /// labeled alternative in <see cref="EveryGrammarParser.math_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitMath_Distance([NotNull] EveryGrammarParser.Math_DistanceContext context) { }

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
    }
}