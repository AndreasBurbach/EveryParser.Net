using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;

namespace EveryParser.CalculatorListener
{
    public partial class EveryGrammarCalculatorListener
    {
        /// <summary>
        /// Enter a parse tree produced by the <c>Random_Decimal</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_Decimal([NotNull] EveryGrammarParser.Random_DecimalContext context)
        {
            Node.AddChildNode(_randomizer.NextDouble() + _randomizer.Next());
        }

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
            Func<object, object> calculation = x =>
            {
                int count = int.Parse(x.ToString());

                var result = new List<object>(count);
                for (int i = 0; i < count; i += 1)
                    result.Add(_randomizer.NextDouble() + _randomizer.Next());

                return result;
            };
            Node.Value = CalculationHelper.CalcNumericUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object, object> calculation = (x, y) =>
            {
                int min = int.Parse(x.ToString());
                int max = int.Parse(y.ToString());

                double result = _randomizer.Next(min, max);

                if (result == min)
                    result += Math.Abs(_randomizer.NextDouble());
                else
                    result += _randomizer.NextDouble();

                return result;
            };
            Node.Value = CalculationHelper.CalcNumericBinary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object, object, object> calculation = (w, x, y) =>
             {
                 int count = int.Parse(w.ToString());
                 int min = int.Parse(x.ToString());
                 int max = int.Parse(y.ToString());

                 var result = new List<object>(count);
                 for (int i = 0; i < count; i += 1)
                 {
                     double res = _randomizer.Next(min, max);

                     if (res == min)
                         res += Math.Abs(_randomizer.NextDouble());
                     else
                         res += _randomizer.NextDouble();

                     result.Add(res);
                 }

                 return result;
             };
            Node.Value = CalculationHelper.CalcNumericTri(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Random_Integer</c>
        /// labeled alternative in <see cref="EveryGrammarParser.random_function_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterRandom_Integer([NotNull] EveryGrammarParser.Random_IntegerContext context)
        {
            Node.AddChildNode(_randomizer.Next());
        }

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
            Func<object, object> calculation = x =>
            {
                int count = int.Parse(x.ToString());

                var result = new List<object>(count);
                for (int i = 0; i < count; i += 1)
                    result.Add(_randomizer.Next());

                return result;
            };

            Node.Value = CalculationHelper.CalcNumericUnary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object, object> calculation = (x, y) =>
             {
                 int min = int.Parse(x.ToString());
                 int max = int.Parse(y.ToString());

                 return _randomizer.Next(min, max);
             };
            Node.Value = CalculationHelper.CalcNumericBinary(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
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
            Func<object, object, object, object> calculation = (w, x, y) =>
            {
                int count = int.Parse(w.ToString());
                int min = int.Parse(x.ToString());
                int max = int.Parse(y.ToString());

                var result = new List<object>(count);
                for (int i = 0; i < count; i += 1)
                    result.Add(_randomizer.Next(min, max));

                return result;
            };
            Node.Value = CalculationHelper.CalcNumericTri(context, ErrorCollector, calculation, Node.Children);
            Node = Node.Parent;
        }
    }
}