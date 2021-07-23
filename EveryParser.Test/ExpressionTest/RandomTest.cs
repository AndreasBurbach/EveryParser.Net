using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class RandomTest
    {
        [Fact]
        public void Test()
        {
            Assert.NotNull(Expression.CalculateDecimal("rnddecimal()"));
            Assert.NotNull(Expression.CalculateDecimal("rnddecimal(1,10)"));

            Assert.NotEmpty(Expression.CalculateArray("rnddecimal(5)"));
            Assert.NotEmpty(Expression.CalculateArray("rnddecimal(5, 1, 10)"));

            Assert.NotNull(Expression.CalculateDecimal("rndinteger()"));
            Assert.NotNull(Expression.CalculateDecimal("rndinteger(1,10)"));

            Assert.NotEmpty(Expression.CalculateArray("rndinteger(5)"));
            Assert.NotEmpty(Expression.CalculateArray("rndinteger(5, 1, 10)"));
        }
    }
}