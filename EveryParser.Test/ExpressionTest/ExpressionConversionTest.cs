using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionConversionTest
    {
        [Fact]
        public void TrigonometrieConversionTest()
        {
            Assert.Equal(1.11111111111111m, Expression.CalculateDecimal("degreetograd(1)"));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1.11111111111111m, 2.22222222222222m }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("degreetograd([1,2])")));

            Assert.Equal(0.0174532925199433m, Expression.CalculateDecimal("degreetoradian(1)"));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 0.0174532925199433m, 0.0349065850398866m }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("degreetoradian([1,2])")));

            Assert.Equal(0.9m, Expression.CalculateDecimal("gradtodegree(1)"));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 0.9, 1.8 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("gradtodegree([1,2])")));

            Assert.Equal(0.015707963267949m, Expression.CalculateDecimal("gradtoradian(1)"));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 0.015707963267949m, 0.0314159265358979m }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("gradtoradian([1,2])")));

            Assert.Equal(57.2957795130823m, Expression.CalculateDecimal("radiantodegree(1)"));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 57.2957795130823m, 114.591559026165m }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("radiantodegree([1,2])")));

            Assert.Equal(63.6619772367581m, Expression.CalculateDecimal("radiantograd(1)"));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 63.6619772367581m, 127.323954473516m }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("radiantograd([1,2])")));
        }

        [Fact]
        public void TypConversionTest()
        {
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("toarray(1)")));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1, 2 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("toarray(\"12\")")));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1, 2 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("toarray([1,2])")));
            Assert.Equal(ExpressionMathArrayTest.ToDecimalArray(new object[] { 1 }), ExpressionMathArrayTest.ToDecimalArray(Expression.CalculateArray("toarray(true)")));

            Assert.Equal(1, Expression.CalculateDecimal("tonumber(1)"));
            Assert.Equal(12, Expression.CalculateDecimal("tonumber(\"12\")"));
            Assert.Equal(1, Expression.CalculateDecimal("tonumber(true)"));

            Assert.Equal(true, Expression.CalculateBoolean("toboolean(1)"));
            Assert.Equal(true, Expression.CalculateBoolean("toboolean(\"12\")"));
            Assert.Equal(true, Expression.CalculateBoolean("toboolean(true)"));
            Assert.Equal(true, Expression.CalculateBoolean("toboolean([1,2])"));

            Assert.Equal(false, Expression.CalculateBoolean("toboolean(-1)"));
            Assert.Equal(false, Expression.CalculateBoolean("toboolean(\"\")"));
            Assert.Equal(false, Expression.CalculateBoolean("toboolean(false)"));
            Assert.Equal(false, Expression.CalculateBoolean("toboolean([])"));

            Assert.Equal("1", Expression.CalculateString("tostring(1)"));
            Assert.Equal("12", Expression.CalculateString("tostring(\"12\")"));
            Assert.Equal("True", Expression.CalculateString("tostring(true)"));
        }
    }
}