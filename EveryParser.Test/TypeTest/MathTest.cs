using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class MathTest
    {
        [Fact]
        public void DefaultTests()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("1+0"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("125 + 375"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("15.25 + 7.90 + 3.12"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("1200 - 450"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("10 - 9 + 8 - 7 + 6 - 5 + 4 - 3 + 2 - 1"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("1.05 * 12,000"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("125 * 216 * 343"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("1000 // 65"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("13.5 / 18.27"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("(2*3 + 3*4 + 4*5) // (10 - 5)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("1+ ((2*3 + 3*4 + 4*5) // ((10 - 5) * 5))"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("1+1*3"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("42"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("(1+1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("(1+1)//(3)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("(1+1)/(3.1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("2**2"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("2**2+1"));
        }

        [Fact]
        public void FactorTests()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("-1"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("~1"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("+1"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("!11"));
        }

        [Fact]
        public void FactorConstTest()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("e"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("pi"));
        }

        [Fact]
        public void FunctionTests()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("abs(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("abs(-1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("acos(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("acosh(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("asin(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("asinh(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("atan(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("atan2(1,1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("atanh(0.5)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("cbrt(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("cbrt(27)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("cos(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("cosh(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ceilling(1.1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("clamp(1,10,20)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("crosssum(1800)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("exp(2)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("floor(1.1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("log(12, 2)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("log2(12)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("log10(12)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("max(2,3)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("max(3)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("min(2,3)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("min(2)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("pow(3,2)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("root(9,2)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("round(2.2)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("round(2.234,2)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("sin(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("sinh(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("sqrt(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("sqrt(100)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("tan(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("tanh(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("truncate(1.234)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("gcd(10,5)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("lcm(10,5)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("binomial(3,2)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("acot(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("acoth(10)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("acsc(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("acsch(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("asec(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("asech(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("cot(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("coth(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("csc(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("csch(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("sec(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("sech(1)"));
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