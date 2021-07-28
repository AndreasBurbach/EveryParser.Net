using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class ArrayTest
    {
        [Fact]
        public void TestArraySlicing()
        {
            //Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5]"));

            //Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("[1,2,3,4,5][0]"));
            //Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][[0,2]]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][0:1]"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][0:2]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][[0,1]:2]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][0:[1,2]]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][[0,1]:[2,3]]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][0:2:1]"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][0:5:2]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][[0,1]:5:2]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][0:[3,4]:3]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][0:5:[1,2]]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][[0,1]:[3,5]:[2,3]]"));
        }

        [Fact]
        public void TestArrayMinusSlicing()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("[1,2,3,4,5][-5]"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][[-1,-2]]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][-3:-1]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][[0,-5]:2]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][0:[-3,2]]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][[0,-5]:[-3,2]]"));
        }

        [Fact]
        public void TestArraySlicingWithEmptyExpressions()
        {
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][:-1]"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][:-1:2]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][1:]"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][1::2]"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("[1,2,3,4,5][::2]"));
        }
    }
}