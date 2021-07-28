using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class FunctionTest
    {
        [Fact]
        public void DefaultFunctionTest()
        {
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Concat([1], [2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Count([1,2,3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Distinct([1,1,1,1])"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Distinct([1,2])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Difference([1,2,3], [1,2,3,4])"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("HasDuplicates([1,1,1])"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("HasDuplicates([1,2,3])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Except([1,2,3], [1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("IndexOf([1,2,3], 1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("IndexOf([1,2,3], 4)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("IndexOf([1,2,3], 2, 1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("IndexOf([1,2,3], 1, 1)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("IndexOf([1,2,3], 2, 1, 1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("IndexOf([1,2,3], 1, 1, 1)"));

            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("Lower(\"TEST\")"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Reverse([1,2,3])"));

            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("Upper(\"test\")"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("HasAny([1,2,3])"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("HasAny([])"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("Sort([3,2,1])"));

            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("Trim(\" test \")"));
            Assert.Equal(EveryParserType.ArrayOfString, Expression.GetPossibleResultingType("Trim([ \" \",\"test\", \" \"])"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsBoolean(true)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsBoolean(false)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsBoolean(1)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsNumber(1)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsNumber(true)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsString(\"test\")"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsString(1)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsArray([1,2])"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsArray(1)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsWhitespace(\" \")"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsWhitespace(\" xy  \")"));
        }
    }
}