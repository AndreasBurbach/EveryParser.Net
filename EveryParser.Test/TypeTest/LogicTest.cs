using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class LogicTest
    {
        [Fact]
        public void TestEqual()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("true == true"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("true == false"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 == 1"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 == 2"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"test\" == \"test\""));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"test\" == \"not\""));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"Test\" =i \"test\""));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"Test\" =i \"not\""));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("true != true"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("true != false"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 != 1"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 != 2"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"test\" != \"test\""));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"test\" != \"not\""));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"Test\" !=i \"test\""));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"Test\" !=i \"not\""));
        }

        [Fact]
        public void TestContains()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"test\" in \"test\""));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"test\" in \"not\""));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"Test\" not in \"test\""));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"Test\" not in \"not\""));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"e\" in \"test\""));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"e\" in \"not\""));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"t\" not in \"test\""));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"e\" not in \"not\""));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("0 in [0,1,2]"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("3 not in [0,1,2]"));
        }

        [Fact]
        public void TestLowerGreater()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 >= 1"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 <= 1"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 >= 2"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("2 >= 1"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 <= 2"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("2 <= 1"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 < 2"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("2 < 1"));

            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("1 > 2"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("2 > 1"));
        }
    }
}