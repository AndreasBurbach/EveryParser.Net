using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionFunctionTest
    {
        [Fact]
        public void DefaultFunctionTest()
        {
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1,2 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("concat([1], [2])")));

            Assert.Equal(3, Expression.CalculateDecimal("count([1,2,3])"));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("distinct([1,1,1,1])")));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1, 2 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("distinct([1,2])")));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 4 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("difference([1,2,3], [1,2,3,4])")));

            //Assert.Equal(true, Expression.CalculateBoolean("duplicates([1,1,1])"));
            //Assert.Equal(false, Expression.CalculateBoolean("duplicates([1,2,3])"));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 3 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("except([1,2,3], [1,2])")));

            Assert.Equal(0, Expression.CalculateDecimal("indexOf([1,2,3], 1)"));
            Assert.Equal(-1, Expression.CalculateDecimal("indexOf([1,2,3], 4)"));

            Assert.Equal(1, Expression.CalculateDecimal("indexOf([1,2,3], 2, 1)"));
            Assert.Equal(-1, Expression.CalculateDecimal("indexOf([1,2,3], 1, 1)"));

            //Assert.Equal(1, Expression.CalculateDecimal("indexOf([1,2,3], 2, 1, 1)"));
            Assert.Equal(-1, Expression.CalculateDecimal("indexOf([1,2,3], 1, 1, 1"));

            Assert.Equal("test", Expression.CalculateString("lower(\"TEST\")"));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 3, 2, 1 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("reverse([1,2,3])")));

            Assert.Equal("TEST", Expression.CalculateString("lower(\"test\")"));

            Assert.Equal(true, Expression.CalculateBoolean("any([1,2,3])"));
            Assert.Equal(false, Expression.CalculateBoolean("any([])"));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1, 2, 3 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("sort([3,2,1])")));
        }
    }
}