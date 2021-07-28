using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class FunctionTest
    {
        [Fact]
        public void DefaultFunctionTest()
        {
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("Concat([1], [2])")));

            Assert.Equal(3, Expression.CalculateDecimal("Count([1,2,3])"));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("Distinct([1,1,1,1])")));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("Distinct([1,2])")));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 4 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("Difference([1,2,3], [1,2,3,4])")));

            Assert.Equal(true, Expression.CalculateBoolean("HasDuplicates([1,1,1])"));
            Assert.Equal(false, Expression.CalculateBoolean("HasDuplicates([1,2,3])"));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 3 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("Except([1,2,3], [1,2])")));

            Assert.Equal(0, Expression.CalculateDecimal("IndexOf([1,2,3], 1)"));
            Assert.Equal(-1, Expression.CalculateDecimal("IndexOf([1,2,3], 4)"));

            Assert.Equal(1, Expression.CalculateDecimal("IndexOf([1,2,3], 2, 1)"));
            Assert.Equal(-1, Expression.CalculateDecimal("IndexOf([1,2,3], 1, 1)"));

            Assert.Equal(1, Expression.CalculateDecimal("IndexOf([1,2,3], 2, 1, 1)"));
            Assert.Equal(-1, Expression.CalculateDecimal("IndexOf([1,2,3], 1, 1, 1)"));

            Assert.Equal("test", Expression.CalculateString("Lower(\"TEST\")"));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 3, 2, 1 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("Reverse([1,2,3])")));

            Assert.Equal("TEST", Expression.CalculateString("Upper(\"test\")"));

            Assert.Equal(true, Expression.CalculateBoolean("HasAny([1,2,3])"));
            Assert.Equal(false, Expression.CalculateBoolean("HasAny([])"));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2, 3 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("Sort([3,2,1])")));

            Assert.Equal("test", Expression.CalculateString("Trim(\" test \")"));
            Assert.Single(Expression.CalculateArray("Trim([ \" \",\"test\", \" \"])"));
            Assert.Equal("test", Expression.CalculateArray("Trim([ \" \",\"test\", \" \"])")[0].ToString());

            Assert.Equal(true, Expression.CalculateBoolean("IsBoolean(true)"));
            Assert.Equal(true, Expression.CalculateBoolean("IsBoolean(false)"));
            Assert.Equal(false, Expression.CalculateBoolean("IsBoolean(1)"));

            Assert.Equal(true, Expression.CalculateBoolean("IsNumber(1)"));
            Assert.Equal(false, Expression.CalculateBoolean("IsNumber(true)"));

            Assert.Equal(true, Expression.CalculateBoolean("IsString(\"test\")"));
            Assert.Equal(false, Expression.CalculateBoolean("IsString(1)"));

            Assert.Equal(true, Expression.CalculateBoolean("IsArray([1,2])"));
            Assert.Equal(false, Expression.CalculateBoolean("IsArray(1)"));

            Assert.Equal(true, Expression.CalculateBoolean("IsWhitespace(\" \")"));
            Assert.Equal(false, Expression.CalculateBoolean("IsWhitespace(\" xy  \")"));
        }
    }
}