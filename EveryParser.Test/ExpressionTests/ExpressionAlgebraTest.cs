using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionAlgebraTest
    {
        [Fact]
        public void AdditionDefaultTest()
        {
            Assert.Equal(2.0m, new Expression("1+1").CalculateDecimal());
        }
    }
}