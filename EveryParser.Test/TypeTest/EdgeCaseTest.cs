using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class EdgeCaseTest
    {
        [Fact]
        public void TestSingleNumber()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("42"));
        }

        [Fact]
        public void TestSingleBoolean()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("true"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("false"));
        }

        [Fact]
        public void TestSingleString()
        {
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("\"hello\""));
        }

        [Fact]
        public void TestEmptyArray()
        {
            var result = Expression.GetPossibleResultingType("[]");
            Assert.True(result >= 0);
        }

        [Fact]
        public void TestConstants()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("pi"));
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("e"));
        }

        [Fact]
        public void TestModulo()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("10 % 3"));
        }

        [Fact]
        public void TestPowerOperator()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("2 ** 3"));
        }

        [Fact]
        public void TestIntegerDivision()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("10 // 3"));
        }

        [Fact]
        public void TestFactorial()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("!5"));
        }

        [Fact]
        public void TestNegation()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("-1"));
        }

        [Fact]
        public void TestNotOperator()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("not true"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("not false"));
        }

        [Fact]
        public void TestNestedBrackets()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("((1 + 2) * 3)"));
        }

        [Fact]
        public void TestIsNull()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsNull(1)"));
        }

        [Fact]
        public void TestIsDateTime()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsDatetime(1)"));
        }

        [Fact]
        public void TestIsNumber()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsNumber(1)"));
        }

        [Fact]
        public void TestIsBoolean()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsBoolean(true)"));
        }

        [Fact]
        public void TestIsArray()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsArray([1,2])"));
        }

        [Fact]
        public void TestHasDuplicates()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("HasDuplicates([1,1])"));
        }

        [Fact]
        public void TestHasAny()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("HasAny([1,2])"));
        }
    }
}
