using Antlr4.Runtime.Misc;
using EveryParser.LinQReplaces;
using EveryParser.Types;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;

namespace EveryParser.GrammarListener.CalculatorListener
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Abs(value.GetValue());
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Acos(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Acosh(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Asin(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Asinh(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Atan(value);
            };
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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return Math.Atan2(value1, value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Atanh(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Pow(value, 1d/3d);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Cos(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Cosh(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Ceiling(value.GetValue());
            };
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
            EPDecimal value = 0;
            if (valueList is null)
                value = new EPDecimal(childValues[0]);

            var minList = childValues[1] as List<object>;
            EPDecimal min = 0;
            if (minList is null)
                min = new EPDecimal(childValues[1]);

            var maxList = childValues[2] as List<object>;
            EPDecimal max = 0;
            if (maxList is null)
                max = new EPDecimal(childValues[2]);

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
                        var valueX = new EPDecimal(x);
                        return (object)(valueX < min ? min : valueX > max ? max : value);
                    });
                }
                else if (minList is null && !(maxList is null))
                {
                    if (valueList.Count == maxList.Count)
                    {
                        var result = new List<object>(valueList.Count);
                        for (int i = 0; i < valueList.Count; ++i)
                        {
                            value = new EPDecimal(valueList[i]);
                            max = new EPDecimal(maxList[i]);
                            result.Add((value < min ? min : value > max ? max : value));
                        }
                        Node.Value = result;
                    }
                    else
                    {
                        ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {valueList.Count} Array3 Count {maxList.Count}");
                        Node.Value = null;
                    }
                }
                else if (!(minList is null) && maxList is null)
                {
                    if (valueList.Count == maxList.Count)
                    {
                        var result = new List<object>(valueList.Count);
                        for (int i = 0; i < valueList.Count; ++i)
                        {
                            value = new EPDecimal(valueList[i]);
                            min = new EPDecimal(minList[i]);
                            result.Add((value < min ? min : value > max ? max : value));
                        }
                        Node.Value = result;
                    }
                    else
                    {
                        ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {valueList.Count} Array3 Count {maxList.Count}");
                        Node.Value = null;
                    }
                }
                else if (valueList.Count == minList.Count && minList.Count == maxList.Count)
                {
                    var result = new List<object>(valueList.Count);
                    for (int i = 0; i < valueList.Count; i += 1)
                    {
                        var valueX = new EPDecimal(valueList[i]);
                        var minX = new EPDecimal(minList[i]);
                        var maxX = new EPDecimal(maxList[i]);

                        result.Add(valueX < minX ? minX : valueX > maxX ? maxX : valueX);
                    }
                    Node.Value = result;
                }
                else
                {
                    ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: Array1 Count {valueList.Count} Array2 Count {minList.Count} Array3 Count {maxList.Count}");
                    Node.Value = null;
                }
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
                foreach (var letter in ((long)new EPDecimal(x)).ToString())
                    value += long.Parse(letter.ToString());
                return value;
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
        public void ExitMath_Derivative([NotNull] EveryGrammarParser.Math_DerivativeContext context)
        { }

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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Exp(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Floor(value.GetValue());
            };
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
        public void ExitMath_Integration([NotNull] EveryGrammarParser.Math_IntegrationContext context)
        { }

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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return Math.Log(value1, value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Log(value, 2d);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Log10(value);
            };
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
                    max = Math.Max(max, new EPDecimal(value));
                Node.Value = max;
            }
            else
                Node.Value = new EPDecimal(childValues[0]);

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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return Math.Max((double)value1, (double)value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
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
                    min = Math.Min(min, new EPDecimal(value));
                Node.Value = min;
            }
            else
                Node.Value = new EPDecimal(childValues[0]);

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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return Math.Min((double)value1, (double)value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return Math.Pow(value1, value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Round(value.GetValue());
            };
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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return Math.Round(value1.GetValue(), value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return Math.Pow(value1, 1/value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Sin(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Sinh(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Sqrt(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Tan(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Tanh(value);
            };
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return Math.Truncate(value.GetValue());
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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

            var list = childValues[0] as List<object>;

            if (list is null)
            {
                ErrorCollector.AddError(context, ErrorCode.FirstNotNumberArray, "First parameter must be an Array");
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            if (!double.TryParse(childValues[1].ToString(), out var value))
            {
                ErrorCollector.AddError(context, ErrorCode.SecondNotNumber, "Second parameter must be a number");
                Node.Value = double.NaN;
                Node = Node.Parent;
                return;
            }

            Node.Value = Vector<double>.Build.DenseOfArray(Array.ConvertAll(list.ToArray(), y => (double)new EPDecimal(y))).Norm(value);
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
            Func<List<object>, object> calculation = x => Vector<double>.Build.DenseOfArray(Array.ConvertAll(x.ToArray(), y => (double)new EPDecimal(y))).L2Norm();
            Node.Value = CalculationHelper.CalcListOfNumbersUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<List<object>, object> calculation = x => Vector<double>.Build.DenseOfArray(Array.ConvertAll(x.ToArray(), y => (double)new EPDecimal(y))).InfinityNorm();
            Node.Value = CalculationHelper.CalcListOfNumbersUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return MathNet.Numerics.Euclid.GreatestCommonDivisor(value1, value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return MathNet.Numerics.Euclid.LeastCommonMultiple(value1, value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Converter<object, double> converter = y => (double)new EPDecimal(y);
            Func<List<object>, List<object>, object> calculation = (x, z) =>
                            Vector<double>.Build.DenseOfArray(Array.ConvertAll(x.ToArray(), converter)).DotProduct(
                            Vector<double>.Build.DenseOfArray(Array.ConvertAll(z.ToArray(), converter)));

            Node.Value = CalculationHelper.CalcListOfNumbersBinary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object, object> calculation = (x1, x2) =>
            {
                var value1 = new EPDecimal(x1);
                var value2 = new EPDecimal(x2);
                if (value1.IsNaN || value2.IsNaN)
                    return null;

                return MathNet.Numerics.SpecialFunctions.Binomial(value1, value2);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayBinary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Acot(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Acoth(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Acsc(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Acsch(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Asec(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Asech(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Cot(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Coth(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Csc(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Csch(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Sec(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object> calculation = x =>
            {
                var value = new EPDecimal(x);
                if (value.IsNaN)
                    return null;

                return MathNet.Numerics.Trig.Sech(value);
            };
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }
    }
}