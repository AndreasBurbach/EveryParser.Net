using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionFunctionTest
    {
        [Fact]
        public void DefaultFunctionTest()
        {
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1, 2 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("concat([1], [2])")));

            Assert.Equal(3, Expression.CalculateDecimal("count([1,2,3])"));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("distinct([1,1,1,1])")));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1, 2 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("distinct([1,2])")));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 4 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("difference([1,2,3], [1,2,3,4])")));

            Assert.Equal(true, Expression.CalculateBoolean("hasduplicates([1,1,1])"));
            Assert.Equal(false, Expression.CalculateBoolean("hasduplicates([1,2,3])"));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 3 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("except([1,2,3], [1,2])")));

            Assert.Equal(0, Expression.CalculateDecimal("indexOf([1,2,3], 1)"));
            Assert.Equal(-1, Expression.CalculateDecimal("indexOf([1,2,3], 4)"));

            Assert.Equal(1, Expression.CalculateDecimal("indexOf([1,2,3], 2, 1)"));
            Assert.Equal(-1, Expression.CalculateDecimal("indexOf([1,2,3], 1, 1)"));

            Assert.Equal(1, Expression.CalculateDecimal("indexOf([1,2,3], 2, 1, 1)"));
            Assert.Equal(-1, Expression.CalculateDecimal("indexOf([1,2,3], 1, 1, 1)"));

            Assert.Equal("test", Expression.CalculateString("lower(\"TEST\")"));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 3, 2, 1 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("reverse([1,2,3])")));

            Assert.Equal("TEST", Expression.CalculateString("upper(\"test\")"));

            Assert.Equal(true, Expression.CalculateBoolean("hasany([1,2,3])"));
            Assert.Equal(false, Expression.CalculateBoolean("hasany([])"));

            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1, 2, 3 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("sort([3,2,1])")));

            Assert.Equal("test", Expression.CalculateString("trim(\" test \")"));
            Assert.Single(Expression.CalculateArray("trim([ \" \",\"test\", \" \"])"));
            Assert.Equal("test", Expression.CalculateArray("trim([ \" \",\"test\", \" \"])")[0].ToString());

            Assert.Equal(true, Expression.CalculateBoolean("isboolean(true)"));
            Assert.Equal(true, Expression.CalculateBoolean("isboolean(false)"));
            Assert.Equal(false, Expression.CalculateBoolean("isboolean(1)"));

            Assert.Equal(true, Expression.CalculateBoolean("isnumber(1)"));
            Assert.Equal(false, Expression.CalculateBoolean("isnumber(true)"));

            Assert.Equal(true, Expression.CalculateBoolean("isstring(\"test\")"));
            Assert.Equal(false, Expression.CalculateBoolean("isstring(1)"));

            Assert.Equal(true, Expression.CalculateBoolean("isarray([1,2])"));
            Assert.Equal(false, Expression.CalculateBoolean("isarray(1)"));

            Assert.Equal(true, Expression.CalculateBoolean("iswhitespace(\" \")"));
            Assert.Equal(false, Expression.CalculateBoolean("iswhitespace(\" xy  \")"));
        }
    }
}