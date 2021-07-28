using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class RandomTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("RndDecimal()"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("RndDecimal(1,10)"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("RndDecimal(5)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("RndDecimal(5, 1, 10)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("RndInteger()"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("RndInteger(1,10)"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("RndInteger(5)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("RndInteger(5, 1, 10)"));
        }
    }
}