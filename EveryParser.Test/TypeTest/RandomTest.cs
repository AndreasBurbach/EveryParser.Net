using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class RandomTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("rnddecimal()"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("rnddecimal(1,10)"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("rnddecimal(5)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("rnddecimal(5, 1, 10)"));

            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("rndinteger()"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("rndinteger(1,10)"));

            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("rndinteger(5)"));
            Assert.Equal(EveryParserType.ArrayOfNumber, Expression.GetPossibleResultingType("rndinteger(5, 1, 10)"));
        }
    }
}