using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class ConversionTest
    {
        [Fact]
        public void TrigonometrieConversionTest()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("DegreeToGrad(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("DegreeToGrad([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("DegreeToRadian(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("DegreeToRadian([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("GradToDegree(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("GradToDegree([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("GradToRadian(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("GradToRadian([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("RadianToDegree(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("RadianToDegree([1,2])"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("RadianToGrad(1)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("RadianToGrad([1,2])"));
        }

        [Fact]
        public void TypConversionTest()
        {
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ToArray(1)"));
            Assert.Equal(EveryParserType.ArrayOfString, Expression.GetPossibleResultingType("ToArray(\"12\")"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("ToArray([1,2])"));
            Assert.Equal(EveryParserType.ArrayOfBoolean, Expression.GetPossibleResultingType("ToArray(true)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ToNumber(1)"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ToNumber(\"12\")"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("ToNumber(true)"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("ToBoolean(1)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("ToBoolean(\"12\")"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("ToBoolean(true)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("ToBoolean([1,2])"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("ToBoolean(-1)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("ToBoolean(\"\")"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("ToBoolean(false)"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("ToBoolean([])"));

            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("ToString(1)"));
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("ToString(\"12\")"));
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("ToString(true)"));
        }
    }
}