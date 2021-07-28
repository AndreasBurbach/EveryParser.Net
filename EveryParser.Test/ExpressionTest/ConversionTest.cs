using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ConversionTest
    {
        [Fact]
        public void TrigonometrieConversionTest()
        {
            Assert.Equal(1.11111111111111m, Expression.CalculateDecimal("DegreeToGrad(1)"));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1.11111111111111m, 2.22222222222222m }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("DegreeToGrad([1,2])")));

            Assert.Equal(0.0174532925199433m, Expression.CalculateDecimal("DegreeToRadian(1)"));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 0.0174532925199433m, 0.0349065850398866m }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("DegreeToRadian([1,2])")));

            Assert.Equal(0.9m, Expression.CalculateDecimal("GradToDegree(1)"));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 0.9, 1.8 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("GradToDegree([1,2])")));

            Assert.Equal(0.015707963267949m, Expression.CalculateDecimal("GradToRadian(1)"));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 0.015707963267949m, 0.0314159265358979m }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("GradToRadian([1,2])")));

            Assert.Equal(57.2957795130823m, Expression.CalculateDecimal("RadianToDegree(1)"));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 57.2957795130823m, 114.591559026165m }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("RadianToDegree([1,2])")));

            Assert.Equal(63.6619772367581m, Expression.CalculateDecimal("RadianToGrad(1)"));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 63.6619772367581m, 127.323954473516m }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("RadianToGrad([1,2])")));
        }

        [Fact]
        public void TypConversionTest()
        {
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("ToArray(1)")));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("ToArray(\"12\")")));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1, 2 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("ToArray([1,2])")));
            Assert.Equal(MathArrayTest.ToDecimalArray(new object[] { 1 }), MathArrayTest.ToDecimalArray(Expression.CalculateArray("ToArray(true)")));

            Assert.Equal(1, Expression.CalculateDecimal("ToNumber(1)"));
            Assert.Equal(12, Expression.CalculateDecimal("ToNumber(\"12\")"));
            Assert.Equal(1, Expression.CalculateDecimal("ToNumber(true)"));

            Assert.Equal(true, Expression.CalculateBoolean("ToBoolean(1)"));
            Assert.Equal(true, Expression.CalculateBoolean("ToBoolean(\"12\")"));
            Assert.Equal(true, Expression.CalculateBoolean("ToBoolean(true)"));
            Assert.Equal(true, Expression.CalculateBoolean("ToBoolean([1,2])"));

            Assert.Equal(false, Expression.CalculateBoolean("ToBoolean(-1)"));
            Assert.Equal(false, Expression.CalculateBoolean("ToBoolean(\"\")"));
            Assert.Equal(false, Expression.CalculateBoolean("ToBoolean(false)"));
            Assert.Equal(false, Expression.CalculateBoolean("ToBoolean([])"));

            Assert.Equal("1", Expression.CalculateString("ToString(1)"));
            Assert.Equal("12", Expression.CalculateString("ToString(\"12\")"));
            Assert.Equal("True", Expression.CalculateString("ToString(true)"));
        }
    }
}