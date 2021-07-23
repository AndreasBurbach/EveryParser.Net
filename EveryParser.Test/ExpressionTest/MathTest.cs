using System;
using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class MathTest
    {
        [Fact]
        public void DefaultTests()
        {
            Assert.Equal(1 + 0, Expression.CalculateDecimal("1+0"));
            Assert.Equal(125 + 375, Expression.CalculateDecimal("125 + 375"));

            Assert.Equal(15.25m + 7.90m + 3.12m, Expression.CalculateDecimal("15.25 + 7.90 + 3.12"));
            Assert.Equal(1200 - 450, Expression.CalculateDecimal("1200 - 450"));

            Assert.Equal(10 - 9 + 8 - 7 + 6 - 5 + 4 - 3 + 2 - 1, Expression.CalculateDecimal("10 - 9 + 8 - 7 + 6 - 5 + 4 - 3 + 2 - 1"));
            Assert.Equal(1.05m * 12m, Expression.CalculateDecimal("1.05 * 12,000"));

            Assert.Equal(125 * 216 * 343, Expression.CalculateDecimal("125 * 216 * 343"));
            Assert.Equal(1000 / 65, Expression.CalculateDecimal("1000 // 65"));

            Assert.Equal(13.5m / 18.27m, Expression.CalculateDecimal("13.5 / 18.27"));
            Assert.Equal((2 * 3 + 3 * 4 + 4 * 5) / (10 - 5), Expression.CalculateDecimal("(2*3 + 3*4 + 4*5) // (10 - 5)"));

            Assert.Equal(1 + ((2 * 3 + 3 * 4 + 4 * 5) / ((10 - 5) * 5)), Expression.CalculateDecimal("1+ ((2*3 + 3*4 + 4*5) // ((10 - 5) * 5))"));
            Assert.Equal(1 + 1 * 3, Expression.CalculateDecimal("1+1*3"));

            Assert.Equal(42, Expression.CalculateDecimal("42"));
            Assert.Equal((1 + 1), Expression.CalculateDecimal("(1+1)"));

            Assert.Equal((1 + 1) / (3), Expression.CalculateDecimal("(1+1)//(3)"));
            Assert.Equal((1 + 1) / (3.1m), Expression.CalculateDecimal("(1+1)/(3.1)"));

            Assert.Equal(4, Expression.CalculateDecimal("2**2"));
            Assert.Equal(5, Expression.CalculateDecimal("2**2+1"));
        }

        [Fact]
        public void FactorTests()
        {
            Assert.Equal(-1, Expression.CalculateDecimal("-1"));
            Assert.Equal(~1, Expression.CalculateDecimal("~1"));
            Assert.Equal(+1, Expression.CalculateDecimal("+1"));
            Assert.Equal(39916800, Expression.CalculateDecimal("!11"));
        }

        [Fact]
        public void FactorConstTest()
        {
            Assert.Equal(2.71828182845904523536028747135266249775724709369995957496696762772407663035354759457138217852516642742746m, Expression.CalculateDecimal("e"));
            Assert.Equal(3.14159265358979323846264338327950288419716939937510582097494459230781640628620899862803482534211706798214808651m, Expression.CalculateDecimal("pi"));
        }

        [Fact]
        public void FunctionTests()
        {
            Assert.Equal(1, Expression.CalculateDecimal("abs(1)"));
            Assert.Equal(1, Expression.CalculateDecimal("abs(-1)"));

            Assert.Equal((decimal)Math.Acos(1), Expression.CalculateDecimal("acos(1)"));
            Assert.Equal((decimal)Math.Acosh(1), Expression.CalculateDecimal("acosh(1)"));

            Assert.Equal((decimal)Math.Asin(1), Expression.CalculateDecimal("asin(1)"));
            Assert.Equal((decimal)Math.Asinh(1), Expression.CalculateDecimal("asinh(1)"));

            Assert.Equal((decimal)Math.Atan(1), Expression.CalculateDecimal("atan(1)"));
            Assert.Equal((decimal)Math.Atan2(1, 1), Expression.CalculateDecimal("atan2(1,1)"));
            Assert.Equal((decimal)Math.Atanh(0.5), Expression.CalculateDecimal("atanh(0.5)"));

            Assert.Equal((decimal)Math.Cbrt(1), Expression.CalculateDecimal("cbrt(1)"));
            Assert.Equal((decimal)Math.Cbrt(27), Expression.CalculateDecimal("cbrt(27)"));

            Assert.Equal((decimal)Math.Cos(1), Expression.CalculateDecimal("cos(1)"));
            Assert.Equal((decimal)Math.Cosh(1), Expression.CalculateDecimal("cosh(1)"));

            Assert.Equal((decimal)Math.Ceiling(1.1), Expression.CalculateDecimal("ceilling(1.1)"));
            Assert.Equal((decimal)Math.Clamp(1, 10, 20), Expression.CalculateDecimal("clamp(1,10,20)"));

            Assert.Equal(9, Expression.CalculateDecimal("crosssum(1800)"));
            Assert.Equal((decimal)Math.Exp(2), Expression.CalculateDecimal("exp(2)"));

            Assert.Equal((decimal)Math.Floor(1.1), Expression.CalculateDecimal("floor(1.1)"));

            Assert.Equal((decimal)Math.Log(12, 2), Expression.CalculateDecimal("log(12, 2)"));
            Assert.Equal((decimal)Math.Log2(12), Expression.CalculateDecimal("log2(12)"));
            Assert.Equal((decimal)Math.Log10(12), Expression.CalculateDecimal("log10(12)"));

            Assert.Equal(3, Expression.CalculateDecimal("max(2,3)"));
            Assert.Equal(3, Expression.CalculateDecimal("max(3)"));

            Assert.Equal(2, Expression.CalculateDecimal("min(2,3)"));
            Assert.Equal(2, Expression.CalculateDecimal("min(2)"));

            Assert.Equal((decimal)Math.Pow(3, 2), Expression.CalculateDecimal("pow(3,2)"));
            Assert.Equal((decimal)Math.Pow(9, 1 / 2d), Expression.CalculateDecimal("root(9,2)"));

            Assert.Equal((decimal)Math.Round(2.2), Expression.CalculateDecimal("round(2.2)"));
            Assert.Equal((decimal)Math.Round(2.234, 2), Expression.CalculateDecimal("round(2.234,2)"));

            Assert.Equal((decimal)Math.Sin(1), Expression.CalculateDecimal("sin(1)"));
            Assert.Equal((decimal)Math.Sinh(1), Expression.CalculateDecimal("sinh(1)"));

            Assert.Equal((decimal)Math.Sqrt(1), Expression.CalculateDecimal("sqrt(1)"));
            Assert.Equal((decimal)Math.Sqrt(100), Expression.CalculateDecimal("sqrt(100)"));

            Assert.Equal((decimal)Math.Tan(1), Expression.CalculateDecimal("tan(1)"));
            Assert.Equal((decimal)Math.Tanh(1), Expression.CalculateDecimal("tanh(1)"));

            Assert.Equal((decimal)Math.Truncate(1.234), Expression.CalculateDecimal("truncate(1.234)"));

            Assert.Equal((decimal)MathNet.Numerics.Euclid.GreatestCommonDivisor(10, 5), Expression.CalculateDecimal("gcd(10,5)"));

            Assert.Equal((decimal)MathNet.Numerics.Euclid.LeastCommonMultiple(10, 5), Expression.CalculateDecimal("lcm(10,5)"));

            Assert.Equal((decimal)MathNet.Numerics.SpecialFunctions.Binomial(3, 2), Expression.CalculateDecimal("binomial(3,2)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Acot(1), Expression.CalculateDecimal("acot(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Acoth(10), Expression.CalculateDecimal("acoth(10)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Acsc(1), Expression.CalculateDecimal("acsc(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Acsch(1), Expression.CalculateDecimal("acsch(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Asec(1), Expression.CalculateDecimal("asec(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Asech(1), Expression.CalculateDecimal("asech(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Cot(1), Expression.CalculateDecimal("cot(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Coth(1), Expression.CalculateDecimal("coth(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Csc(1), Expression.CalculateDecimal("csc(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Csch(1), Expression.CalculateDecimal("csch(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Sec(1), Expression.CalculateDecimal("sec(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Sech(1), Expression.CalculateDecimal("sech(1)"));
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