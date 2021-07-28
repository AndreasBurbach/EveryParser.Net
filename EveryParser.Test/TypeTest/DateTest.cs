using EveryParser.GrammarListener.TypeListener;
using System;
using System.Globalization;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class DateTest
    {
        [Fact]
        public void DefaultTests()
        {
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("DateTime.Now"));

            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType($"DateTime(\"{DateTime.Now.ToString(CultureInfo.InvariantCulture)}\")"));
            Assert.Equal(EveryParserType.ArrayOfDateTime, Expression.GetPossibleResultingType($"DateTime([\"Test\",\"Test\"])"));

            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("DateTime(2021,2,3)"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("DateTime(2021,2,3,4)"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("DateTime(2021,2,3,4,5)"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("DateTime(2021,2,3,4,5,6)"));
            Assert.Equal(EveryParserType.DateTime, Expression.GetPossibleResultingType("DateTime(2021,2,3,4,5,6,7)"));

            Assert.Equal(EveryParserType.ArrayOfDateTime, Expression.GetPossibleResultingType("DateTime(2021,2,3,4,5,6,[1,2])"));
        }
    }
}