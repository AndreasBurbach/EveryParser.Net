using Antlr4.Runtime.Misc;
using System;

namespace EveryParser
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
        public void ExitConvert_ToArray([NotNull] EveryGrammarParser.Convert_ToArrayContext context) { nur für strings oder einem array das nur ein element mit string enthält }

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
        public void ExitConvert_ToBoolean([NotNull] EveryGrammarParser.Convert_ToBooleanContext context) { alles was nicht leer oder über 0 ist }

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
        public void ExitConvert_ToNumber([NotNull] EveryGrammarParser.Convert_ToNumberContext context) { nur mit strings, oder array mit nur einem element das eine nummer ist }

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
        public void ExitConvert_ToString([NotNull] EveryGrammarParser.Convert_ToStringContext context) { tostring }

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
            Func<object, object> calculation = x => (object)MathNet.Numerics.Trig.DegreeToGrad(Convert.ToDouble(x));
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
            Func<object, object> calculation = x => (object)MathNet.Numerics.Trig.DegreeToRadian(Convert.ToDouble(x));
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
            Func<object, object> calculation = x => (object)MathNet.Numerics.Trig.GradToDegree(Convert.ToDouble(x));
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
            Func<object, object> calculation = x => (object)MathNet.Numerics.Trig.GradToRadian(Convert.ToDouble(x));
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
            Func<object, object> calculation = x => (object)MathNet.Numerics.Trig.RadianToDegree(Convert.ToDouble(x));
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
            Func<object, object> calculation = x => (object)MathNet.Numerics.Trig.RadianToGrad(Convert.ToDouble(x));
            Node.Value = CalculationHelper.CalcNumericOrNumericArrayUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }
    }
}