using System;
using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionArrayTest
    {
        [Fact]
        public void MathArrayTests()
        {
            Assert.Equal(ToDecimalArray(new object[] { 100, 1, 4 }), ToDecimalArray(Expression.CalculateArray("abs([-100,1,4])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Acos(1), Math.Acos(0.5) }), ToDecimalArray(Expression.CalculateArray("acos([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Acosh(1), Math.Acosh(12) }), ToDecimalArray(Expression.CalculateArray("acosh([1, 12])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Asin(1), Math.Asin(0.5) }), ToDecimalArray(Expression.CalculateArray("asin([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Asinh(1), Math.Asinh(12) }), ToDecimalArray(Expression.CalculateArray("asinh([1, 12])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Atan(1), Math.Atan(0.5) }), ToDecimalArray(Expression.CalculateArray("atan([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Atan2(1, 1), Math.Atan2(0.5, 1) }), ToDecimalArray(Expression.CalculateArray("atan2([1, 0.5],1)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Atan2(1, 1), Math.Atan2(0.5, 0.5) }), ToDecimalArray(Expression.CalculateArray("atan2([1, 0.5],[1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Atanh(0.5), Math.Atanh(0.3) }), ToDecimalArray(Expression.CalculateArray("atanh([0.5, 0.3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Cbrt(1), Math.Cbrt(27) }), ToDecimalArray(Expression.CalculateArray("cbrt([1,27])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Cos(1), Math.Cos(0.5) }), ToDecimalArray(Expression.CalculateArray("cos([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Cosh(1), Math.Cosh(0.5) }), ToDecimalArray(Expression.CalculateArray("cosh([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Ceiling(1.1), Math.Ceiling(2.2) }), ToDecimalArray(Expression.CalculateArray("ceilling([1.1, 2.2])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Clamp(1, 10, 20), Math.Clamp(2, 10, 20) }), ToDecimalArray(Expression.CalculateArray("clamp([1,2],10,20)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Clamp(1, 10, 20), Math.Clamp(2, 20, 30) }), ToDecimalArray(Expression.CalculateArray("clamp([1,2],[10,20],[20,30])")));

            Assert.Equal(ToDecimalArray(new object[] { 9, 9 }), ToDecimalArray(Expression.CalculateArray("crosssum([1800, 1404])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Exp(2), Math.Exp(3) }), ToDecimalArray(Expression.CalculateArray("exp([2, 3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Floor(1.1), Math.Floor(2.3) }), ToDecimalArray(Expression.CalculateArray("floor([1.1, 2.2])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Log(12, 2), Math.Log(16, 2) }), ToDecimalArray(Expression.CalculateArray("log([12, 16], 2)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Log(12, 2), Math.Log(27, 3) }), ToDecimalArray(Expression.CalculateArray("log([12, 27], [2, 3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Log2(12), Math.Log2(15) }), ToDecimalArray(Expression.CalculateArray("log2([12, 15])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Log10(12), Math.Log10(15) }), ToDecimalArray(Expression.CalculateArray("log10([12, 15])")));

            Assert.Equal(5.5m, Expression.CalculateDecimal("max([1,2,3,4,5.5])"));
            Assert.Equal(1m, Expression.CalculateDecimal("min([1,2,3,4,5.5])"));

            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(3, 2), Math.Pow(2, 2) }), ToDecimalArray(Expression.CalculateArray("pow([3,2],2)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(3, 2), Math.Pow(2, 3) }), ToDecimalArray(Expression.CalculateArray("pow([3,2],[2,3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(9, 1 / 2d), Math.Pow(4, 1 / 2d) }), ToDecimalArray(Expression.CalculateArray("root([9, 4],2)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(9, 1 / 2d), Math.Pow(27, 1 / 3d) }), ToDecimalArray(Expression.CalculateArray("root([9,27],[2,3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Round(2.2), Math.Round(3.3) }), ToDecimalArray(Expression.CalculateArray("round([2.2, 3.3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Round(2.234, 2), Math.Round(1.234, 2) }), ToDecimalArray(Expression.CalculateArray("round([2.234, 1.234],2)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Round(2.234, 2), Math.Round(1.234, 1) }), ToDecimalArray(Expression.CalculateArray("round([2.234, 1.234],[2, 1])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Sin(1), Math.Sin(0.5) }), ToDecimalArray(Expression.CalculateArray("sin([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Sinh(1), Math.Sinh(0.5) }), ToDecimalArray(Expression.CalculateArray("sinh([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { 10, 1, 2 }), ToDecimalArray(Expression.CalculateArray("sqrt([100,1,4])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Tan(1), Math.Tan(0.5) }), ToDecimalArray(Expression.CalculateArray("tan([1, 0.5])")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Tanh(1), Math.Tanh(0.5) }), ToDecimalArray(Expression.CalculateArray("tanh([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Truncate(1.234), Math.Truncate(2.234) }), ToDecimalArray(Expression.CalculateArray("truncate([1.234, 2.234])")));
        }

        private static decimal[] ToDecimalArray(object[] array)
        {
            decimal[] result = new decimal[array.Length];
            for (int i = 0; i < array.Length; ++i)
                result[i] = Convert.ToDecimal(array[i]);

            return result;
        }
    }
}