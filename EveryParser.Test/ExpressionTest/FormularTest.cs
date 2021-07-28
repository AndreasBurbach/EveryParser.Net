using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class FormularTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(1, Expression.CalculateDecimal("count([1,2,3]) // max([1,2,3])"));
        }
    }
}