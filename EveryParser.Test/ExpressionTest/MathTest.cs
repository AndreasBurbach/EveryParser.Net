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

            Assert.Equal(4, Expression.CalculateDecimal("1<<2"));
            Assert.Equal(1, Expression.CalculateDecimal("2>>1"));
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
            Assert.Equal(1, Expression.CalculateDecimal("Abs(1)"));
            Assert.Equal(1, Expression.CalculateDecimal("Abs(-1)"));

            Assert.Equal((decimal)Math.Acos(1), Expression.CalculateDecimal("ACos(1)"));
            Assert.Equal((decimal)Math.Acosh(1), Expression.CalculateDecimal("ACosH(1)"));

            Assert.Equal((decimal)Math.Asin(1), Expression.CalculateDecimal("ASin(1)"));
            Assert.Equal((decimal)Math.Asinh(1), Expression.CalculateDecimal("ASinH(1)"));

            Assert.Equal((decimal)Math.Atan(1), Expression.CalculateDecimal("ATan(1)"));
            Assert.Equal((decimal)Math.Atan2(1, 1), Expression.CalculateDecimal("ATan2(1,1)"));
            Assert.Equal((decimal)Math.Atanh(0.5), Expression.CalculateDecimal("ATanH(0.5)"));

            Assert.Equal((decimal)Math.Cbrt(1), Expression.CalculateDecimal("Cbrt(1)"));
            Assert.Equal((decimal)Math.Cbrt(27), Expression.CalculateDecimal("Cbrt(27)"));

            Assert.Equal((decimal)Math.Cos(1), Expression.CalculateDecimal("Cos(1)"));
            Assert.Equal((decimal)Math.Cosh(1), Expression.CalculateDecimal("CosH(1)"));

            Assert.Equal((decimal)Math.Ceiling(1.1), Expression.CalculateDecimal("Ceilling(1.1)"));
            Assert.Equal((decimal)Math.Clamp(1, 10, 20), Expression.CalculateDecimal("Clamp(1,10,20)"));

            Assert.Equal(9, Expression.CalculateDecimal("CrossSum(1800)"));
            Assert.Equal((decimal)Math.Exp(2), Expression.CalculateDecimal("Exp(2)"));

            Assert.Equal((decimal)Math.Floor(1.1), Expression.CalculateDecimal("Floor(1.1)"));

            Assert.Equal((decimal)Math.Log(12, 2), Expression.CalculateDecimal("Log(12, 2)"));
            Assert.Equal((decimal)Math.Log2(12), Expression.CalculateDecimal("Log2(12)"));
            Assert.Equal((decimal)Math.Log10(12), Expression.CalculateDecimal("Log10(12)"));

            Assert.Equal(3, Expression.CalculateDecimal("Max(2,3)"));
            Assert.Equal(3, Expression.CalculateDecimal("Max(3)"));

            Assert.Equal(2, Expression.CalculateDecimal("Min(2,3)"));
            Assert.Equal(2, Expression.CalculateDecimal("Min(2)"));

            Assert.Equal((decimal)Math.Pow(3, 2), Expression.CalculateDecimal("Pow(3,2)"));
            Assert.Equal((decimal)Math.Pow(9, 1 / 2d), Expression.CalculateDecimal("Root(9,2)"));

            Assert.Equal((decimal)Math.Round(2.2), Expression.CalculateDecimal("Round(2.2)"));
            Assert.Equal((decimal)Math.Round(2.234, 2), Expression.CalculateDecimal("Round(2.234,2)"));

            Assert.Equal((decimal)Math.Sin(1), Expression.CalculateDecimal("Sin(1)"));
            Assert.Equal((decimal)Math.Sinh(1), Expression.CalculateDecimal("SinH(1)"));

            Assert.Equal((decimal)Math.Sqrt(1), Expression.CalculateDecimal("Sqrt(1)"));
            Assert.Equal((decimal)Math.Sqrt(100), Expression.CalculateDecimal("Sqrt(100)"));

            Assert.Equal((decimal)Math.Tan(1), Expression.CalculateDecimal("Tan(1)"));
            Assert.Equal((decimal)Math.Tanh(1), Expression.CalculateDecimal("TanH(1)"));

            Assert.Equal((decimal)Math.Truncate(1.234), Expression.CalculateDecimal("Truncate(1.234)"));

            Assert.Equal((decimal)MathNet.Numerics.Euclid.GreatestCommonDivisor(10, 5), Expression.CalculateDecimal("Gcd(10,5)"));

            Assert.Equal((decimal)MathNet.Numerics.Euclid.LeastCommonMultiple(10, 5), Expression.CalculateDecimal("Lcm(10,5)"));

            Assert.Equal((decimal)MathNet.Numerics.SpecialFunctions.Binomial(3, 2), Expression.CalculateDecimal("Binomial(3,2)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Acot(1), Expression.CalculateDecimal("ACot(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Acoth(10), Expression.CalculateDecimal("ACotH(10)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Acsc(1), Expression.CalculateDecimal("ACsc(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Acsch(1), Expression.CalculateDecimal("ACscH(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Asec(1), Expression.CalculateDecimal("ASec(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Asech(1), Expression.CalculateDecimal("ASecH(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Cot(1), Expression.CalculateDecimal("Cot(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Coth(1), Expression.CalculateDecimal("CotH(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Csc(1), Expression.CalculateDecimal("Csc(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Csch(1), Expression.CalculateDecimal("CscH(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Sec(1), Expression.CalculateDecimal("Sec(1)"));

            Assert.Equal((decimal)MathNet.Numerics.Trig.Sech(1), Expression.CalculateDecimal("SecH(1)"));
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