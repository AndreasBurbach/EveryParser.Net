using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class FormularTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(1, Expression.CalculateDecimal("Count([1,2,3]) // Max([1,2,3])"));
        }
    }
}