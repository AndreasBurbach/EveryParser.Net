using System;
using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionMathTest
    {
        [Fact]
        public void DefaultTests()
        {
            Assert.Equal(1 + 0, Expression.CalculatePrimitiveDecimal("1+0"));
            Assert.Equal(125 + 375, Expression.CalculatePrimitiveDecimal("125 + 375"));

            Assert.Equal(15.25m + 7.90m + 3.12m, Expression.CalculatePrimitiveDecimal("15.25 + 7.90 + 3.12"));
            Assert.Equal(1200 - 450, Expression.CalculatePrimitiveDecimal("1200 - 450"));

            Assert.Equal(10 - 9 + 8 - 7 + 6 - 5 + 4 - 3 + 2 - 1, Expression.CalculatePrimitiveDecimal("10 - 9 + 8 - 7 + 6 - 5 + 4 - 3 + 2 - 1"));
            Assert.Equal(1.05m * 12m, Expression.CalculatePrimitiveDecimal("1.05 * 12,000"));

            Assert.Equal(125 * 216 * 343, Expression.CalculatePrimitiveDecimal("125 * 216 * 343"));
            Assert.Equal(1000 / 65, Expression.CalculatePrimitiveDecimal("1000 // 65"));

            Assert.Equal(13.5m / 18.27m, Expression.CalculatePrimitiveDecimal("13.5 / 18.27"));
            Assert.Equal((2 * 3 + 3 * 4 + 4 * 5) / (10 - 5), Expression.CalculatePrimitiveDecimal("(2*3 + 3*4 + 4*5) // (10 - 5)"));

            Assert.Equal(1 + ((2 * 3 + 3 * 4 + 4 * 5) / ((10 - 5) * 5)), Expression.CalculatePrimitiveDecimal("1+ ((2*3 + 3*4 + 4*5) // ((10 - 5) * 5))"));
            Assert.Equal(1 + 1 * 3, Expression.CalculatePrimitiveDecimal("1+1*3"));

            Assert.Equal(42, Expression.CalculatePrimitiveDecimal("42"));
            Assert.Equal((1 + 1), Expression.CalculatePrimitiveDecimal("(1+1)"));

            Assert.Equal((1 + 1) / (3), Expression.CalculatePrimitiveDecimal("(1+1)//(3)"));
            Assert.Equal((1 + 1) / (3.1m), Expression.CalculatePrimitiveDecimal("(1+1)/(3.1)"));

            Assert.Equal(4, Expression.CalculatePrimitiveDecimal("2^2"));
            Assert.Equal(5, Expression.CalculatePrimitiveDecimal("2^2+1"));
        }

        [Fact]
        public void FactorTests()
        {
            Assert.Equal(-1, Expression.CalculatePrimitiveDecimal("-1"));
            Assert.Equal(~1, Expression.CalculatePrimitiveDecimal("~1"));
            Assert.Equal(+1, Expression.CalculatePrimitiveDecimal("+1"));
        }

        [Fact]
        public void FactorConstTest()
        {
            Assert.Equal(2.71828182845904523536028747135266249775724709369995957496696762772407663035354759457138217852516642742746m, Expression.CalculatePrimitiveDecimal("e"));
            Assert.Equal(3.14159265358979323846264338327950288419716939937510582097494459230781640628620899862803482534211706798214808651m, Expression.CalculatePrimitiveDecimal("pi"));
        }

        [Fact]
        public void FunctionTests()
        {
            Assert.Equal(1, Expression.CalculatePrimitiveDecimal("abs(1)"));
            Assert.Equal(1, Expression.CalculatePrimitiveDecimal("abs(-1)"));

            Assert.Equal((decimal)Math.Acos(1), Expression.CalculatePrimitiveDecimal("acos(1)"));
            Assert.Equal((decimal)Math.Acosh(1), Expression.CalculatePrimitiveDecimal("acosh(1)"));

            Assert.Equal((decimal)Math.Asin(1), Expression.CalculatePrimitiveDecimal("asin(1)"));
            Assert.Equal((decimal)Math.Asinh(1), Expression.CalculatePrimitiveDecimal("asinh(1)"));

            Assert.Equal((decimal)Math.Atan(1), Expression.CalculatePrimitiveDecimal("atan(1)"));
            Assert.Equal((decimal)Math.Atan2(1, 1), Expression.CalculatePrimitiveDecimal("atan2(1,1)"));
            Assert.Equal((decimal)Math.Atanh(0.5), Expression.CalculatePrimitiveDecimal("atanh(0.5)"));

            Assert.Equal((decimal)Math.Cbrt(1), Expression.CalculatePrimitiveDecimal("cbrt(1)"));
            Assert.Equal((decimal)Math.Cbrt(27), Expression.CalculatePrimitiveDecimal("cbrt(27)"));

            Assert.Equal((decimal)Math.Cos(1), Expression.CalculatePrimitiveDecimal("cos(1)"));
            Assert.Equal((decimal)Math.Cosh(1), Expression.CalculatePrimitiveDecimal("cosh(1)"));

            Assert.Equal((decimal)Math.Ceiling(1.1), Expression.CalculatePrimitiveDecimal("ceilling(1.1)"));
            Assert.Equal((decimal)Math.Clamp(1, 10, 20), Expression.CalculatePrimitiveDecimal("clamp(1,10,20)"));

            Assert.Equal(9, Expression.CalculatePrimitiveDecimal("crosssum(1800)"));
            Assert.Equal((decimal)Math.Exp(2), Expression.CalculatePrimitiveDecimal("exp(2)"));

            Assert.Equal((decimal)Math.Floor(1.1), Expression.CalculatePrimitiveDecimal("floor(1.1)"));

            Assert.Equal((decimal)Math.Log(12, 2), Expression.CalculatePrimitiveDecimal("log(12, 2)"));
            Assert.Equal((decimal)Math.Log2(12), Expression.CalculatePrimitiveDecimal("log2(12)"));
            Assert.Equal((decimal)Math.Log10(12), Expression.CalculatePrimitiveDecimal("log10(12)"));

            Assert.Equal(3, Expression.CalculatePrimitiveDecimal("max(2,3)"));
            Assert.Equal(2, Expression.CalculatePrimitiveDecimal("min(2,3)"));

            Assert.Equal((decimal)Math.Pow(3, 2), Expression.CalculatePrimitiveDecimal("pow(3,2)"));
            Assert.Equal((decimal)Math.Pow(9, 1 / 2d), Expression.CalculatePrimitiveDecimal("root(9,2)"));

            Assert.Equal((decimal)Math.Round(2.2), Expression.CalculatePrimitiveDecimal("round(2.2)"));
            Assert.Equal((decimal)Math.Round(2.234, 2), Expression.CalculatePrimitiveDecimal("round(2.234,2)"));

            Assert.Equal((decimal)Math.Sin(1), Expression.CalculatePrimitiveDecimal("sin(1)"));
            Assert.Equal((decimal)Math.Sinh(1), Expression.CalculatePrimitiveDecimal("sinh(1)"));

            Assert.Equal((decimal)Math.Sqrt(1), Expression.CalculatePrimitiveDecimal("sqrt(1)"));
            Assert.Equal((decimal)Math.Sqrt(100), Expression.CalculatePrimitiveDecimal("sqrt(100)"));

            Assert.Equal((decimal)Math.Tan(1), Expression.CalculatePrimitiveDecimal("tan(1)"));
            Assert.Equal((decimal)Math.Tanh(1), Expression.CalculatePrimitiveDecimal("tanh(1)"));

            Assert.Equal((decimal)Math.Truncate(1.234), Expression.CalculatePrimitiveDecimal("truncate(1.234)"));
        }

        [Fact]
        public void DerivateTest()
        {
        }

        [Fact]
        public void IntegrationTest()
        {
        }
    }
}