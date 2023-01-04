using MathNet.Numerics.LinearAlgebra;
using System;
using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class MathArrayTest
    {
        [Fact]
        public void MathArrayDefaultTest()
        {
            Assert.Equal(ToDecimalArray(new object[] { 2, 4, 8 }), ToDecimalArray(Expression.CalculateArray("[1,2,4] + [1,2,4])")));
            Assert.Equal(ToDecimalArray(new object[] { 0, 0, 0 }), ToDecimalArray(Expression.CalculateArray("[1,2,4] - [1,2,4])")));

            Assert.Equal(ToDecimalArray(new object[] { 1, 4, 16 }), ToDecimalArray(Expression.CalculateArray("[1,2,4] * [1,2,4])")));
            Assert.Equal(ToDecimalArray(new object[] { 1, 1, 1 }), ToDecimalArray(Expression.CalculateArray("[1,2,4] / [1,2,4])")));
            Assert.Equal(ToDecimalArray(new object[] { 1, 1, 1 }), ToDecimalArray(Expression.CalculateArray("[1,2,4] // [1,2,4])")));

            Assert.Equal(ToDecimalArray(new object[] { 1, 4, 16 }), ToDecimalArray(Expression.CalculateArray("[1,2,4] ** 2)")));
            Assert.Equal(ToDecimalArray(new object[] { 2, 4, 16 }), ToDecimalArray(Expression.CalculateArray("2 ** [1,2,4])")));
            Assert.Equal(ToDecimalArray(new object[] { 1, 4, 256 }), ToDecimalArray(Expression.CalculateArray("[1,2,4] ** [1,2,4])")));
        }

        [Fact]
        public void MathArrayTests()
        {
            Assert.Equal(ToDecimalArray(new object[] { 100, 1, 4 }), ToDecimalArray(Expression.CalculateArray("Abs([-100,1,4])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Acos(1), Math.Acos(0.5) }), ToDecimalArray(Expression.CalculateArray("ACos([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Acosh(1), Math.Acosh(12) }), ToDecimalArray(Expression.CalculateArray("ACosH([1, 12])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Asin(1), Math.Asin(0.5) }), ToDecimalArray(Expression.CalculateArray("ASin([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Asinh(1), Math.Asinh(12) }), ToDecimalArray(Expression.CalculateArray("ASinH([1, 12])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Atan(1), Math.Atan(0.5) }), ToDecimalArray(Expression.CalculateArray("ATan([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Atan2(1, 1), Math.Atan2(0.5, 1) }), ToDecimalArray(Expression.CalculateArray("ATan2([1, 0.5],1)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Atan2(1, 1), Math.Atan2(0.5, 0.5) }), ToDecimalArray(Expression.CalculateArray("ATan2([1, 0.5],[1, 0.5])")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Atan2(1, 1), Math.Atan2(1, 0.5) }), ToDecimalArray(Expression.CalculateArray("ATan2(1,[1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Atanh(0.5), Math.Atanh(0.3) }), ToDecimalArray(Expression.CalculateArray("ATanH([0.5, 0.3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Cbrt(1), Math.Cbrt(27) }), ToDecimalArray(Expression.CalculateArray("Cbrt([1,27])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Cos(1), Math.Cos(0.5) }), ToDecimalArray(Expression.CalculateArray("Cos([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Cosh(1), Math.Cosh(0.5) }), ToDecimalArray(Expression.CalculateArray("CosH([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Ceiling(1.1), Math.Ceiling(2.2) }), ToDecimalArray(Expression.CalculateArray("Ceilling([1.1, 2.2])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Clamp(1, 10, 20), Math.Clamp(2, 10, 20) }), ToDecimalArray(Expression.CalculateArray("Clamp([1,2],10,20)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Clamp(1, 10, 20), Math.Clamp(2, 20, 30) }), ToDecimalArray(Expression.CalculateArray("Clamp([1,2],[10,20],[20,30])")));

            Assert.Equal(ToDecimalArray(new object[] { 9, 9 }), ToDecimalArray(Expression.CalculateArray("CrossSum([1800, 1404])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Exp(2), Math.Exp(3) }), ToDecimalArray(Expression.CalculateArray("Exp([2, 3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Floor(1.1), Math.Floor(2.3) }), ToDecimalArray(Expression.CalculateArray("Floor([1.1, 2.2])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Log(12, 2), Math.Log(16, 2) }), ToDecimalArray(Expression.CalculateArray("Log([12, 16], 2)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Log(12, 2), Math.Log(27, 3) }), ToDecimalArray(Expression.CalculateArray("Log([12, 27], [2, 3])")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Log(12, 2), Math.Log(12, 3) }), ToDecimalArray(Expression.CalculateArray("Log(12, [2, 3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Log2(12), Math.Log2(15) }), ToDecimalArray(Expression.CalculateArray("Log2([12, 15])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Log10(12), Math.Log10(15) }), ToDecimalArray(Expression.CalculateArray("Log10([12, 15])")));

            Assert.Equal(5.5m, Expression.CalculateDecimal("Max([1,2,3,4,5.5])"));
            Assert.Equal(1m, Expression.CalculateDecimal("Min([1,2,3,4,5.5])"));

            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(3, 2), Math.Pow(2, 2) }), ToDecimalArray(Expression.CalculateArray("Pow([3,2],2)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(3, 2), Math.Pow(2, 3) }), ToDecimalArray(Expression.CalculateArray("Pow([3,2],[2,3])")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(3, 2), Math.Pow(3, 3) }), ToDecimalArray(Expression.CalculateArray("Pow(3,[2,3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(9, 1 / 2d), Math.Pow(4, 1 / 2d) }), ToDecimalArray(Expression.CalculateArray("Root([9, 4],2)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(9, 1 / 2d), Math.Pow(27, 1 / 3d) }), ToDecimalArray(Expression.CalculateArray("Root([9,27],[2,3])")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Pow(9, 1 / 2d), Math.Pow(9, 1 / 3d) }), ToDecimalArray(Expression.CalculateArray("Root(9,[2,3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Round(2.2), Math.Round(3.3) }), ToDecimalArray(Expression.CalculateArray("Round([2.2, 3.3])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Round(2.234, 2), Math.Round(1.234, 2) }), ToDecimalArray(Expression.CalculateArray("Round([2.234, 1.234],2)")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Round(2.234, 2), Math.Round(1.234, 1) }), ToDecimalArray(Expression.CalculateArray("Round([2.234, 1.234],[2, 1])")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Round(2.234, 2), Math.Round(2.234, 1) }), ToDecimalArray(Expression.CalculateArray("Round(2.234,[2, 1])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Sin(1), Math.Sin(0.5) }), ToDecimalArray(Expression.CalculateArray("Sin([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Sinh(1), Math.Sinh(0.5) }), ToDecimalArray(Expression.CalculateArray("SinH([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { 10, 1, 2 }), ToDecimalArray(Expression.CalculateArray("Sqrt([100,1,4])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Tan(1), Math.Tan(0.5) }), ToDecimalArray(Expression.CalculateArray("Tan([1, 0.5])")));
            Assert.Equal(ToDecimalArray(new object[] { Math.Tanh(1), Math.Tanh(0.5) }), ToDecimalArray(Expression.CalculateArray("TanH([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { Math.Truncate(1.234), Math.Truncate(2.234) }), ToDecimalArray(Expression.CalculateArray("Truncate([1.234, 2.234])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Euclid.GreatestCommonDivisor(10, 5), MathNet.Numerics.Euclid.GreatestCommonDivisor(20, 10) }), ToDecimalArray(Expression.CalculateArray("Gcd([10,20], [5,10])")));
            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Euclid.GreatestCommonDivisor(10, 5), MathNet.Numerics.Euclid.GreatestCommonDivisor(20, 5) }), ToDecimalArray(Expression.CalculateArray("Gcd([10,20], 5)")));
            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Euclid.GreatestCommonDivisor(10, 5), MathNet.Numerics.Euclid.GreatestCommonDivisor(10, 10) }), ToDecimalArray(Expression.CalculateArray("Gcd(10, [5,10])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Euclid.LeastCommonMultiple(10, 5), MathNet.Numerics.Euclid.LeastCommonMultiple(20, 10) }), ToDecimalArray(Expression.CalculateArray("Lcm([10,20], [5,10])")));
            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Euclid.LeastCommonMultiple(10, 5), MathNet.Numerics.Euclid.LeastCommonMultiple(20, 5) }), ToDecimalArray(Expression.CalculateArray("Lcm([10,20], 5)")));
            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Euclid.LeastCommonMultiple(10, 5), MathNet.Numerics.Euclid.LeastCommonMultiple(10, 10) }), ToDecimalArray(Expression.CalculateArray("Lcm(10, [5,10])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.SpecialFunctions.Binomial(3, 2), MathNet.Numerics.SpecialFunctions.Binomial(4, 5) }), ToDecimalArray(Expression.CalculateArray("Binomial([3,4],[2,5])")));
            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.SpecialFunctions.Binomial(3, 2), MathNet.Numerics.SpecialFunctions.Binomial(4, 2) }), ToDecimalArray(Expression.CalculateArray("Binomial([3,4], 2)")));
            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.SpecialFunctions.Binomial(3, 2), MathNet.Numerics.SpecialFunctions.Binomial(3, 5) }), ToDecimalArray(Expression.CalculateArray("Binomial(3,[2,5])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Acot(10), MathNet.Numerics.Trig.Acot(15) }), ToDecimalArray(Expression.CalculateArray("ACot([10, 15])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Acoth(10), MathNet.Numerics.Trig.Acoth(15) }), ToDecimalArray(Expression.CalculateArray("ACotH([10, 15])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Acsc(1), MathNet.Numerics.Trig.Acsc(2) }), ToDecimalArray(Expression.CalculateArray("ACsc([1, 2])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Acsch(1), MathNet.Numerics.Trig.Acsch(0.5) }), ToDecimalArray(Expression.CalculateArray("ACscH([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Asec(1), MathNet.Numerics.Trig.Asec(5) }), ToDecimalArray(Expression.CalculateArray("ASec([1, 5])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Asech(1), MathNet.Numerics.Trig.Asech(0.5) }), ToDecimalArray(Expression.CalculateArray("ASecH([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Cot(1), MathNet.Numerics.Trig.Cot(0.5) }), ToDecimalArray(Expression.CalculateArray("Cot([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Coth(1), MathNet.Numerics.Trig.Coth(0.5) }), ToDecimalArray(Expression.CalculateArray("CotH([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Csc(1), MathNet.Numerics.Trig.Csc(0.5) }), ToDecimalArray(Expression.CalculateArray("Csc([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Csch(1), MathNet.Numerics.Trig.Csch(0.5) }), ToDecimalArray(Expression.CalculateArray("CscH([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Sec(1), MathNet.Numerics.Trig.Sec(0.5) }), ToDecimalArray(Expression.CalculateArray("Sec([1, 0.5])")));

            Assert.Equal(ToDecimalArray(new object[] { MathNet.Numerics.Trig.Sech(1), MathNet.Numerics.Trig.Sech(0.5) }), ToDecimalArray(Expression.CalculateArray("SecH([1, 0.5])")));

            Assert.Equal((decimal)Vector<double>.Build.DenseOfArray(new double[] { 1, 0.5 }).DotProduct(Vector<double>.Build.DenseOfArray(new double[] { 1, 0.5 })), Expression.CalculateDecimal("DotProduct([1, 0.5],[1, 0.5])"));

            Assert.Equal((decimal)Vector<double>.Build.DenseOfArray(new double[] { 1, 0.5 }).L2Norm(), Expression.CalculateDecimal("EulerNorm([1, 0.5])"));

            Assert.Equal((decimal)Vector<double>.Build.DenseOfArray(new double[] { 1, 0.5 }).InfinityNorm(), Expression.CalculateDecimal("MaxNorm([1, 0.5])"));

            Assert.Equal((decimal)Vector<double>.Build.DenseOfArray(new double[] { 1, 0.5 }).Norm(1), Expression.CalculateDecimal("Norm([1, 0.5], 1)"));
        }

        [Fact]
        public void MathStatisticsArrayTests()
        {
            Assert.Equal(MathNet.Numerics.Statistics.ArrayStatistics.Mean(new double[] { 1, 2, 3, 4, 5.5 }), (double)Expression.CalculateDecimal("Mean([1,2,3,4,5.5])"));

            Assert.Equal(MathNet.Numerics.Statistics.ArrayStatistics.MedianInplace(new double[] { 1, 2, 3, 4, 5.5 }), (double)Expression.CalculateDecimal("Median([1,2,3,4,5.5])"));

            Assert.Equal(MathNet.Numerics.Statistics.ArrayStatistics.Variance(new double[] { 1, 2, 3, 4, 5.5 }), (double)Expression.CalculateDecimal("Variance([1,2,3,4,5.5])"));

            Assert.Equal(MathNet.Numerics.Statistics.ArrayStatistics.Covariance(new double[] { 1, 2, 3, 4, 5.5 }, new double[] { 1, 2, 3, 4, 5.5 }), (double)Expression.CalculateDecimal("CoVariance([1,2,3,4,5.5], [1,2,3,4,5.5])"));

            Assert.Equal(MathNet.Numerics.Statistics.ArrayStatistics.StandardDeviation(new double[] { 1, 2, 3, 4, 5.5 }), (double)Expression.CalculateDecimal("Std([1,2,3,4,5.5])"), 12);

            Assert.Equal(MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(new double[] { 1, 2, 3, 4, 5.5 }, 0.75), (double)Expression.CalculateDecimal("Quantil([1,2,3,4,5.5], 0.75)"));

            Assert.Equal(MathNet.Numerics.Statistics.Correlation.Pearson(new double[] { 1, 2, 3, 4, 5.5 }, new double[] { 1, 2, 3, 4, 5.5 }), (double)Expression.CalculateDecimal("Pearson([1,2,3,4,5.5], [1,2,3,4,5.5])"));

            Assert.Equal(MathNet.Numerics.Statistics.Correlation.Spearman(new double[] { 1, 2, 3, 4, 5.5 }, new double[] { 1, 2, 3, 4, 5.5 }), (double)Expression.CalculateDecimal("Spearman([1,2,3,4,5.5], [1,2,3,4,5.5])"));
        }

        public static decimal[] ToDecimalArray(object[] array)
        {
            if (array == null)
                return new decimal[0];

            decimal[] result = new decimal[array.Length];
            for (int i = 0; i < array.Length; ++i)
                result[i] = Convert.ToDecimal(array[i]);

            return result;
        }
    }
}