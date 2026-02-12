using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class StringTest
    {
        [Fact]
        public void TestStringLiteral()
        {
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("\"hello\""));
        }

        [Fact]
        public void TestStringConcatenation()
        {
            // String concatenation with + is not supported in type inference
            // It returns None since + on strings is not a recognized operation
            var type = Expression.GetPossibleResultingType("\"hello\" + \" world\"");
            Assert.Equal(EveryParserType.None, type);
        }

        [Fact]
        public void TestStringEquality()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"test\" == \"test\""));
        }

        [Fact]
        public void TestStringInequality()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"test\" != \"other\""));
        }

        [Fact]
        public void TestStringEqualityIgnoreCase()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"Test\" =i \"test\""));
        }

        [Fact]
        public void TestStringContains()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"e\" in \"test\""));
        }

        [Fact]
        public void TestStringNotContains()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("\"x\" not in \"test\""));
        }

        [Fact]
        public void TestStringLower()
        {
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("Lower(\"TEST\")"));
        }

        [Fact]
        public void TestStringUpper()
        {
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("Upper(\"test\")"));
        }

        [Fact]
        public void TestStringTrim()
        {
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("Trim(\" test \")"));
        }

        [Fact]
        public void TestStringReverse()
        {
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("Reverse(\"test\")"));
        }

        [Fact]
        public void TestStringToString()
        {
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("ToString(1)"));
            Assert.Equal(EveryParserType.String, Expression.GetPossibleResultingType("ToString(true)"));
        }

        [Fact]
        public void TestIsString()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsString(\"test\")"));
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsString(1)"));
        }

        [Fact]
        public void TestIsWhitespace()
        {
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("IsWhitespace(\" \")"));
        }

        [Fact]
        public void TestStringIndexOf()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("IndexOf(\"test\", \"e\")"));
        }

        [Fact]
        public void TestStringCount()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("Count(\"test\")"));
        }
    }
}
