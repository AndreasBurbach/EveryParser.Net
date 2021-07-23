using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class FunctionTest
    {
        [Fact]
        public void DefaultFunctionTest()
        {
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("concat([1], [2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("count([1,2,3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("distinct([1,1,1,1])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("distinct([1,2])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("difference([1,2,3], [1,2,3,4])"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("hasduplicates([1,1,1])"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("hasduplicates([1,2,3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("except([1,2,3], [1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("indexOf([1,2,3], 1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("indexOf([1,2,3], 4)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("indexOf([1,2,3], 2, 1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("indexOf([1,2,3], 1, 1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("indexOf([1,2,3], 2, 1, 1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("indexOf([1,2,3], 1, 1, 1)"));

            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("lower(\"TEST\")"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("reverse([1,2,3])"));

            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("upper(\"test\")"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("hasany([1,2,3])"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("hasany([])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("sort([3,2,1])"));

            //Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("trim(\" test \")"));
            Assert.Equal(EveryParserType.ArrayOfString, Expression.GetPossibleResultingType("trim([ \" \",\"test\", \" \"])"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("isboolean(true)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("isboolean(false)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("isboolean(1)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("isnumber(1)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("isnumber(true)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("isstring(\"test\")"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("isstring(1)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("isarray([1,2])"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("isarray(1)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("iswhitespace(\" \")"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("iswhitespace(\" xy  \")"));
        }
    }
}