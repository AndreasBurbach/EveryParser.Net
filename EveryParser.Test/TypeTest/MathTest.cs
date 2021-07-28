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
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Abs(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Abs(-1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ACos(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ACosH(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ASin(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ASinH(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ATan(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ATan2(1,1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ATanH(0.5)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Cbrt(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Cbrt(27)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Cos(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("CosH(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Ceilling(1.1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Clamp(1,10,20)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Exp(2)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("CrossSum(1800)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Floor(1.1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Log(12, 2)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Log2(12)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Log10(12)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Max(2,3)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Max(3)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Min(2,3)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Min(2)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Pow(3,2)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Root(9,2)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Round(2.2)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Round(2.234,2)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Sin(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("SinH(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Sqrt(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Sqrt(100)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Tan(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("TanH(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Truncate(1.234)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Gcd(10,5)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Lcm(10,5)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Binomial(3,2)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ACot(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ACotH(10)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ACsc(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ACscH(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ASec(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ASecH(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Cot(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("CotH(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Csc(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("CscH(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Sec(1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("SecH(1)"));
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