using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionRandomTest
    {
        [Fact]
        public void RandomTest()
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