using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class ConversionTest
    {
        [Fact]
        public void TrigonometrieConversionTest()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("degreetograd(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("degreetograd([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("degreetoradian(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("degreetoradian([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("gradtodegree(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("gradtodegree([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("gradtoradian(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("gradtoradian([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("radiantodegree(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("radiantodegree([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("radiantograd(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("radiantograd([1,2])"));
        }

        [Fact]
        public void TypConversionTest()
        {
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("toarray(1)"));
            Assert.Equal(EveryParserType.ArrayOfString, Expression.GetPossibleResultingType("toarray(\"12\")"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("toarray([1,2])"));
            Assert.Equal(EveryParserType.ArrayOfBoolean, Expression.GetPossibleResultingType("toarray(true)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("tonumber(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("tonumber(\"12\")"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("tonumber(true)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("toboolean(1)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("toboolean(\"12\")"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("toboolean(true)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("toboolean([1,2])"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("toboolean(-1)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("toboolean(\"\")"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("toboolean(false)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("toboolean([])"));

            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("tostring(1)"));
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("tostring(\"12\")"));
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("tostring(true)"));
        }
    }
}