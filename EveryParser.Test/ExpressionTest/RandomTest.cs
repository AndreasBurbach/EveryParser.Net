using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class RandomTest
    {
        [Fact]
        public void Test()
        {
            Assert.NotNull(Expression.CalculateDecimal("RndDecimal()"));
            Assert.NotNull(Expression.CalculateDecimal("RndDecimal(1,10)"));

            Assert.NotEmpty(Expression.CalculateArray("RndDecimal(5)"));
            Assert.NotEmpty(Expression.CalculateArray("RndDecimal(5, 1, 10)"));

            Assert.NotNull(Expression.CalculateDecimal("RndInteger()"));
            Assert.NotNull(Expression.CalculateDecimal("RndInteger(1,10)"));

            Assert.NotEmpty(Expression.CalculateArray("RndInteger(5)"));
            Assert.NotEmpty(Expression.CalculateArray("RndInteger(5, 1, 10)"));
        }
    }
}