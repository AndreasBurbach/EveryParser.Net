using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionArrayTest
    {
        [Fact]
        public void TestArraySlicing()
        {
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1, 2, 3, 4, 5 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5]")));
            Assert.Equal(1, Expression.CalculateDecimal("[1,2,3,4,5][0]"));
        }
    }
}