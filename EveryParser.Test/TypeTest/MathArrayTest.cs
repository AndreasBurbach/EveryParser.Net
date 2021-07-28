using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class MathArrayTest
    {
        [Fact]
        public void MathArrayDefaultTest()
        {
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,4] + [1,2,4])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,4] - [1,2,4])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,4] * [1,2,4])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,4] / [1,2,4])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,4] // [1,2,4])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,4] ** 2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("2 ** [1,2,4])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,4] ** [1,2,4])"));
        }

        [Fact]
        public void MathArrayTests()
        {
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Abs([-100,1,4])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ACos([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ACosH([1, 12])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ASin([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ASinH([1, 12])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ATan([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ATan2([1, 0.5],1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ATan2([1, 0.5],[1, 0.5])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ATan2(1,[1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ATanH([0.5, 0.3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Cbrt([1,27])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Cos([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("CosH([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Ceilling([1.1, 2.2])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Clamp([1,2],10,20)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Clamp([1,2],[10,20],[20,30])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("CrossSum([1800, 1404])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Exp([2, 3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Floor([1.1, 2.2])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Log([12, 16], 2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Log([12, 27], [2, 3])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Log(12, [2, 3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Log2([12, 15])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Log10([12, 15])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Max([1,2,3,4,5.5])"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Min([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Pow([3,2],2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Pow([3,2],[2,3])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Pow(3,[2,3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Root([9, 4],2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Root([9,27],[2,3])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Root(9,[2,3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Round([2.2, 3.3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Round([2.234, 1.234],2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Round([2.234, 1.234],[2, 1])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Round(2.234,[2, 1])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Sin([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("SinH([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Sqrt([100,1,4])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Tan([1, 0.5])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("TanH([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Truncate([1.234, 2.234])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Gcd([10,20], [5,10])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Gcd([10,20], 5)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Gcd(10, [5,10])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Lcm([10,20], [5,10])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Lcm([10,20], 5)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Lcm(10, [5,10])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Binomial([3,4],[2,5])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Binomial([3,4], 2)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Binomial(3,[2,5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ACot([10, 15])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ACotH([10, 15])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ACsc([1, 2])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ACscH([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ASec([1, 5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ASecH([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Cot([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("CotH([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Csc([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("CscH([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Sec([1, 0.5])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("SecH([1, 0.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("DotProduct([1, 0.5],[1, 0.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("EulerNorm([1, 0.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("MaxNorm([1, 0.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Norm([1, 0.5], 1)"));
        }

        [Fact]
        public void MathStatisticsArrayTests()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Mean([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Median([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Variance([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("CoVariance([1,2,3,4,5.5], [1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Std([1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Quantil([1,2,3,4,5.5], 0.75)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Pearson([1,2,3,4,5.5], [1,2,3,4,5.5])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Spearman([1,2,3,4,5.5], [1,2,3,4,5.5])"));
        }
    }
}