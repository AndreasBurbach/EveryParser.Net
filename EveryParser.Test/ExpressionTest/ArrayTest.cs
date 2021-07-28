using System.Collections.Generic;
using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ArrayTest
    {
        [Fact]
        public void TestArraySlicing()
        {
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2, 3, 4, 5 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5]")));

            Assert.Equal(1, Expression.CalculateDecimal("[1,2,3,4,5][0]"));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 3 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][[0,2]]")));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][0:1]")));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][0:2]")));

            var result = Expression.CalculateArray("[1,2,3,4,5][[0,1]:2]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 2 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));

            result = Expression.CalculateArray("[1,2,3,4,5][0:[1,2]]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));

            result = Expression.CalculateArray("[1,2,3,4,5][[0,1]:[2,3]]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 2, 3 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][0:2:1]")));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 3, 5 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][0:5:2]")));

            result = Expression.CalculateArray("[1,2,3,4,5][[0,1]:5:2]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 3, 5 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 2, 4 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));

            result = Expression.CalculateArray("[1,2,3,4,5][0:[3,4]:3]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 4 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));

            result = Expression.CalculateArray("[1,2,3,4,5][0:5:[1,2]]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2, 3, 4, 5 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 3, 5 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));

            result = Expression.CalculateArray("[1,2,3,4,5][[0,1]:[3,5]:[2,3]]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 3 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 2, 5 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));
        }

        [Fact]
        public void TestArrayMinusSlicing()
        {
            Assert.Equal(1, Expression.CalculateDecimal("[1,2,3,4,5][-5]"));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 5, 4 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][[-1,-2]]")));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 3, 4 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][-3:-1]")));

            var result = Expression.CalculateArray("[1,2,3,4,5][[0,-5]:2]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));

            result = Expression.CalculateArray("[1,2,3,4,5][0:[-3,2]]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));

            result = Expression.CalculateArray("[1,2,3,4,5][[0,-5]:[-3,2]]");
            Assert.Equal(2, result.Length);
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray((result[0] as List<object>).ToArray()));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray((result[1] as List<object>).ToArray()));
        }

        [Fact]
        public void TestArraySlicingWithEmptyExpressions()
        {
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2, 3, 4 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][:-1]")));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 3 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][:-1:2]")));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 2, 3, 4, 5 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][1:]")));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 2, 4 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][1::2]")));

            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 3, 5 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("[1,2,3,4,5][::2]")));
        }
    }
}