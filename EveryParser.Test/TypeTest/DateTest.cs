using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class DateTest
    {
        [Fact]
        public void DefaultTests()
        {
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("date.now"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("date(2021)"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("date(2021,2,3)"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("date(2021,2,3,4)"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("date(2021,2,3,4,5)"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("date(2021,2,3,4,5,6)"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("date(2021,2,3,4,5,6,7)"));
        }
    }
}