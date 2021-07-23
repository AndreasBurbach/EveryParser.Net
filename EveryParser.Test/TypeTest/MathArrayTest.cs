using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class MathArrayTest
    {
        [Fact]
        public void MathArrayDefaultTest()
        {
        }

        [Fact]
        public void MathArrayTests()
        {
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("abs([-100,1,4])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("acos([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("acosh([1, 12])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("asin([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("asinh([1, 12])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("atan([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("atan2([1, 0.5],1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("atan2([1, 0.5],[1, 0.5])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("atan2(1,[1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("atanh([0.5, 0.3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("cbrt([1,27])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("cos([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("cosh([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ceilling([1.1, 2.2])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("clamp([1,2],10,20)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("clamp([1,2],[10,20],[20,30])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("crosssum([1800, 1404])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("exp([2, 3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("floor([1.1, 2.2])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("log([12, 16], 2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("log([12, 27], [2, 3])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("log(12, [2, 3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("log2([12, 15])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("log10([12, 15])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("max([1,2,3,4,5.5])"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("min([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("pow([3,2],2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("pow([3,2],[2,3])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("pow(3,[2,3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("root([9, 4],2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("root([9,27],[2,3])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("root(9,[2,3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("round([2.2, 3.3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("round([2.234, 1.234],2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("round([2.234, 1.234],[2, 1])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("round(2.234,[2, 1])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("sin([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("sinh([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("sqrt([100,1,4])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("tan([1, 0.5])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("tanh([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("truncate([1.234, 2.234])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("gcd([10,20], [5,10])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("gcd([10,20], 5)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("gcd(10, [5,10])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("lcm([10,20], [5,10])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("lcm([10,20], 5)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("lcm(10, [5,10])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("binomial([3,4],[2,5])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("binomial([3,4], 2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("binomial(3,[2,5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("acot([10, 15])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("acoth([10, 15])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("acsc([1, 2])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("acsch([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("asec([1, 5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("asech([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("cot([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("coth([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("csc([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("csch([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("sec([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("sech([1, 0.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("dotproduct([1, 0.5],[1, 0.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("eulernorm([1, 0.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("maxnorm([1, 0.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("norm([1, 0.5], 1)"));
        }

        [Fact]
        public void MathStatisticsArrayTests()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("mean([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("median([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("variance([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("covariance([1,2,3,4,5.5], [1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("std([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("quantil([1,2,3,4,5.5], 0.75)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("pearson([1,2,3,4,5.5], [1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("spearman([1,2,3,4,5.5], [1,2,3,4,5.5])"));
        }
    }
}