using System;
using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class EdgeCaseTest
    {
        #region Whitespace Handling

        [Fact]
        public void TestWhitespaceInFormula()
        {
            Assert.Equal(2, Expression.CalculateDecimal("  1 + 1  "));
        }

        [Fact]
        public void TestMultipleSpaces()
        {
            Assert.Equal(2, Expression.CalculateDecimal("1   +   1"));
        }

        [Fact]
        public void TestTabsInFormula()
        {
            Assert.Equal(2, Expression.CalculateDecimal("1\t+\t1"));
        }

        #endregion

        #region Single Values

        [Fact]
        public void TestSingleInteger()
        {
            Assert.Equal(42, Expression.CalculateDecimal("42"));
        }

        [Fact]
        public void TestSingleDecimal()
        {
            Assert.Equal(3.14m, Expression.CalculateDecimal("3.14"));
        }

        [Fact]
        public void TestSingleTrue()
        {
            Assert.Equal(true, Expression.CalculateBoolean("true"));
        }

        [Fact]
        public void TestSingleFalse()
        {
            Assert.Equal(false, Expression.CalculateBoolean("false"));
        }

        [Fact]
        public void TestSingleString()
        {
            Assert.Equal("hello", Expression.CalculateString("\"hello\""));
        }

        [Fact]
        public void TestEmptyString()
        {
            Assert.Equal("", Expression.CalculateString("\"\""));
        }

        #endregion

        #region Constants

        [Fact]
        public void TestPi()
        {
            Assert.Equal(3.14159265358979323846264338327950288419716939937510582097494459230781640628620899862803482534211706798214808651m,
                Expression.CalculateDecimal("pi"));
        }

        [Fact]
        public void TestE()
        {
            Assert.Equal(2.71828182845904523536028747135266249775724709369995957496696762772407663035354759457138217852516642742746m,
                Expression.CalculateDecimal("e"));
        }

        #endregion

        #region Modulo

        [Fact]
        public void TestModulo()
        {
            Assert.Equal(1, Expression.CalculateDecimal("10 % 3"));
            Assert.Equal(0, Expression.CalculateDecimal("10 % 5"));
            Assert.Equal(2, Expression.CalculateDecimal("10 % 4"));
        }

        #endregion

        #region Factorial

        [Fact]
        public void TestFactorial()
        {
            Assert.Equal(1, Expression.CalculateDecimal("!0"));
            Assert.Equal(1, Expression.CalculateDecimal("!1"));
            Assert.Equal(2, Expression.CalculateDecimal("!2"));
            Assert.Equal(6, Expression.CalculateDecimal("!3"));
            Assert.Equal(120, Expression.CalculateDecimal("!5"));
        }

        #endregion

        #region Negative Numbers

        [Fact]
        public void TestNegativeNumber()
        {
            Assert.Equal(-1, Expression.CalculateDecimal("-1"));
            Assert.Equal(-42, Expression.CalculateDecimal("-42"));
        }

        [Fact]
        public void TestNegativeNumberInExpression()
        {
            Assert.Equal(-1, Expression.CalculateDecimal("1 + -2"));
            Assert.Equal(3, Expression.CalculateDecimal("1 - -2"));
        }

        [Fact]
        public void TestDoubleNegation()
        {
            Assert.Equal(1, Expression.CalculateDecimal("--1"));
        }

        #endregion

        #region Complex Expressions

        [Fact]
        public void TestNestedBrackets()
        {
            Assert.Equal(14, Expression.CalculateDecimal("(2 * (3 + 4))"));
            Assert.Equal(20, Expression.CalculateDecimal("((2 + 3) * (1 + 3))"));
        }

        [Fact]
        public void TestOperatorPrecedence()
        {
            Assert.Equal(7, Expression.CalculateDecimal("1 + 2 * 3"));       // 1 + 6 = 7
            Assert.Equal(5, Expression.CalculateDecimal("10 / 2"));           // = 5
            Assert.Equal(5, Expression.CalculateDecimal("10 // 2"));          // = 5
            Assert.Equal(11, Expression.CalculateDecimal("1 + 2 * 3 + 4"));   // 1 + 6 + 4 = 11
        }

        [Fact]
        public void TestPowerOperator()
        {
            Assert.Equal(8, Expression.CalculateDecimal("2 ** 3"));
            Assert.Equal(1, Expression.CalculateDecimal("5 ** 0"));
            Assert.Equal(256, Expression.CalculateDecimal("2 ** 8"));
        }

        #endregion

        #region Bit Shift

        [Fact]
        public void TestBitShiftLeft()
        {
            Assert.Equal(4, Expression.CalculateDecimal("1 << 2"));
            Assert.Equal(8, Expression.CalculateDecimal("1 << 3"));
            Assert.Equal(16, Expression.CalculateDecimal("2 << 3"));
        }

        [Fact]
        public void TestBitShiftRight()
        {
            Assert.Equal(1, Expression.CalculateDecimal("2 >> 1"));
            Assert.Equal(2, Expression.CalculateDecimal("8 >> 2"));
            Assert.Equal(4, Expression.CalculateDecimal("16 >> 2"));
        }

        #endregion

        #region Tilde (Bitwise NOT)

        [Fact]
        public void TestTilde()
        {
            Assert.Equal(~1, Expression.CalculateDecimal("~1"));
            Assert.Equal(~0, Expression.CalculateDecimal("~0"));
            Assert.Equal(~42, Expression.CalculateDecimal("~42"));
        }

        #endregion

        #region Empty Array

        [Fact]
        public void TestEmptyArrayCreation()
        {
            var result = Expression.CalculateArray("[]");
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void TestEmptyArrayCount()
        {
            Assert.Equal(0, Expression.CalculateDecimal("Count([])"));
        }

        [Fact]
        public void TestEmptyArrayHasAny()
        {
            Assert.Equal(false, Expression.CalculateBoolean("HasAny([])"));
        }

        #endregion

        #region String in Expressions

        [Fact]
        public void TestStringEscapedQuotes()
        {
            // The grammar uses \" for escaping quotes inside strings
            var result = Expression.CalculateString("\"say \\\"hello\\\"\"");
            Assert.NotNull(result);
            Assert.Contains("hello", result);
        }

        #endregion

        #region Different Argument Types

        [Fact]
        public void TestDoubleArgument()
        {
            var expr = new Expression("x + 1");
            expr.AddArgument("x", 1.5);
            Assert.Equal(2.5m, expr.CalculateDecimal());
        }

        [Fact]
        public void TestFloatArgument()
        {
            var expr = new Expression("x + 1");
            expr.AddArgument("x", 1.5f);
            Assert.Equal(2.5m, expr.CalculateDecimal());
        }

        [Fact]
        public void TestDecimalArgument()
        {
            var expr = new Expression("x + 1");
            expr.AddArgument("x", 1.5m);
            Assert.Equal(2.5m, expr.CalculateDecimal());
        }

        [Fact]
        public void TestIntArgument()
        {
            var expr = new Expression("x + 1");
            expr.AddArgument("x", 10);
            Assert.Equal(11, expr.CalculateDecimal());
        }

        [Fact]
        public void TestStringArgument()
        {
            var expr = new Expression("x");
            expr.AddArgument("x", "hello");
            Assert.Equal("hello", expr.CalculateString());
        }

        [Fact]
        public void TestIntArrayArgument()
        {
            var expr = new Expression("Count(x)");
            expr.AddArgument("x", new int[] { 1, 2, 3 });
            Assert.Equal(3, expr.CalculateDecimal());
        }

        [Fact]
        public void TestDoubleArrayArgument()
        {
            var expr = new Expression("Count(x)");
            expr.AddArgument("x", new double[] { 1.0, 2.0, 3.0 });
            Assert.Equal(3, expr.CalculateDecimal());
        }

        [Fact]
        public void TestDecimalArrayArgument()
        {
            var expr = new Expression("Count(x)");
            expr.AddArgument("x", new decimal[] { 1.0m, 2.0m, 3.0m });
            Assert.Equal(3, expr.CalculateDecimal());
        }

        [Fact]
        public void TestFloatArrayArgument()
        {
            var expr = new Expression("Count(x)");
            expr.AddArgument("x", new float[] { 1.0f, 2.0f, 3.0f });
            Assert.Equal(3, expr.CalculateDecimal());
        }

        [Fact]
        public void TestStringArrayArgument()
        {
            var expr = new Expression("Count(x)");
            expr.AddArgument("x", new string[] { "a", "b", "c" });
            Assert.Equal(3, expr.CalculateDecimal());
        }

        #endregion
    }
}
