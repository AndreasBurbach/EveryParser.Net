using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionMathTest
    {
        [Fact]
        public void DefaultTests()
        {
            Assert.Equal(1 + 0, new Expression("1+0").CalculateDecimal());
            Assert.Equal(125 + 375, new Expression("125 + 375").CalculateDecimal());
            Assert.Equal(15.25m + 7.90m + 3.12m, new Expression("15.25 + 7.90 + 3.12").CalculateDecimal());
            Assert.Equal(1200 - 450, new Expression("1200 - 450").CalculateDecimal());
            Assert.Equal(10 - 9 + 8 - 7 + 6 - 5 + 4 - 3 + 2 - 1, new Expression("10 - 9 + 8 - 7 + 6 - 5 + 4 - 3 + 2 - 1").CalculateDecimal());
            Assert.Equal(1.05m * 12m, new Expression("1.05 * 12,000").CalculateDecimal());
            Assert.Equal(125 * 216 * 343, new Expression("125 * 216 * 343").CalculateDecimal());
            Assert.Equal(1000 / 65, new Expression("1000 // 65").CalculateDecimal());
            Assert.Equal(13.5m / 18.27m, new Expression("13.5 / 18.27").CalculateDecimal());
            Assert.Equal((2 * 3 + 3 * 4 + 4 * 5) / (10 - 5), new Expression("(2*3 + 3*4 + 4*5) // (10 - 5)").CalculateDecimal());
            Assert.Equal(1 + ((2 * 3 + 3 * 4 + 4 * 5) / ((10 - 5) * 5)), new Expression("1+ ((2*3 + 3*4 + 4*5) // ((10 - 5) * 5))").CalculateDecimal());
            Assert.Equal(1 + 1 * 3, new Expression("1+1*3").CalculateDecimal());
            Assert.Equal(42, new Expression("42").CalculateDecimal());
            Assert.Equal((1 + 1), new Expression("(1+1)").CalculateDecimal());
            Assert.Equal((1 + 1) / (3), new Expression("(1+1)//(3)").CalculateDecimal());
        }

        [Fact]
        public void FunctionTests()
        {
            Assert.Equal(1, new Expression("Min([1,2,3,4,5.5])").CalculateDecimal());
            Assert.Equal(5.5m, new Expression("Max([1,2,3,4,5.5])").CalculateDecimal());
            Assert.Equal(1, new Expression("sqrt(1)").CalculateDecimal());
            Assert.Equal(10, new Expression("sqrt(100)").CalculateDecimal());
            Assert.Equal(new decimal[] { 10, 1, 2 }, new Expression("sqrt([100,1,4])").Calculate());
            Assert.Equal(new decimal[] { 100, 1, 4 }, new Expression("abs([-100,-1,4])").Calculate());
            Assert.Equal(1, new Expression("abs(1)").CalculateDecimal());
            Assert.Equal(-1, new Expression("abs(-1)").CalculateDecimal());
            Assert.Equal(1, new Expression("pow(1,1)").CalculateDecimal());
        }
    }
}