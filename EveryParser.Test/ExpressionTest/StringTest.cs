using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class StringTest
    {
        [Fact]
        public void TestStringLiteral()
        {
            Assert.Equal("hello", Expression.CalculateString("\"hello\""));
            Assert.Equal("", Expression.CalculateString("\"\""));
        }

        [Fact]
        public void TestStringEquality()
        {
            Assert.Equal(true, Expression.CalculateBoolean("\"test\" == \"test\""));
            Assert.Equal(false, Expression.CalculateBoolean("\"test\" == \"other\""));
        }

        [Fact]
        public void TestStringInequality()
        {
            Assert.Equal(false, Expression.CalculateBoolean("\"test\" != \"test\""));
            Assert.Equal(true, Expression.CalculateBoolean("\"test\" != \"other\""));
        }

        [Fact]
        public void TestStringEqualityIgnoreCase()
        {
            Assert.Equal(true, Expression.CalculateBoolean("\"Test\" =i \"test\""));
            Assert.Equal(true, Expression.CalculateBoolean("\"TEST\" =i \"test\""));
            Assert.Equal(false, Expression.CalculateBoolean("\"Test\" =i \"other\""));
        }

        [Fact]
        public void TestStringNotEqualIgnoreCase()
        {
            Assert.Equal(false, Expression.CalculateBoolean("\"Test\" !=i \"test\""));
            Assert.Equal(true, Expression.CalculateBoolean("\"Test\" !=i \"other\""));
        }

        [Fact]
        public void TestStringContains()
        {
            Assert.Equal(true, Expression.CalculateBoolean("\"e\" in \"test\""));
            Assert.Equal(false, Expression.CalculateBoolean("\"x\" in \"test\""));
            Assert.Equal(true, Expression.CalculateBoolean("\"test\" in \"this is a test\""));
        }

        [Fact]
        public void TestStringNotContains()
        {
            Assert.Equal(true, Expression.CalculateBoolean("\"x\" not in \"test\""));
            Assert.Equal(false, Expression.CalculateBoolean("\"e\" not in \"test\""));
        }

        [Fact]
        public void TestStringLower()
        {
            Assert.Equal("test", Expression.CalculateString("Lower(\"TEST\")"));
            Assert.Equal("hello world", Expression.CalculateString("Lower(\"Hello World\")"));
        }

        [Fact]
        public void TestStringUpper()
        {
            Assert.Equal("TEST", Expression.CalculateString("Upper(\"test\")"));
            Assert.Equal("HELLO WORLD", Expression.CalculateString("Upper(\"Hello World\")"));
        }

        [Fact]
        public void TestStringTrim()
        {
            Assert.Equal("test", Expression.CalculateString("Trim(\" test \")"));
            Assert.Equal("test", Expression.CalculateString("Trim(\"test\")"));
        }

        [Fact]
        public void TestStringReverse()
        {
            Assert.Equal("tset", Expression.CalculateString("Reverse(\"test\")"));
            Assert.Equal("cba", Expression.CalculateString("Reverse(\"abc\")"));
        }

        [Fact]
        public void TestStringIsString()
        {
            Assert.Equal(true, Expression.CalculateBoolean("IsString(\"test\")"));
            Assert.Equal(false, Expression.CalculateBoolean("IsString(1)"));
            Assert.Equal(false, Expression.CalculateBoolean("IsString(true)"));
        }

        [Fact]
        public void TestStringIsWhitespace()
        {
            Assert.Equal(true, Expression.CalculateBoolean("IsWhitespace(\" \")"));
            Assert.Equal(true, Expression.CalculateBoolean("IsWhitespace(\"   \")"));
            Assert.Equal(false, Expression.CalculateBoolean("IsWhitespace(\"test\")"));
            Assert.Equal(false, Expression.CalculateBoolean("IsWhitespace(\" test \")"));
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("1", Expression.CalculateString("ToString(1)"));
            Assert.Equal("True", Expression.CalculateString("ToString(true)"));
            Assert.Equal("test", Expression.CalculateString("ToString(\"test\")"));
        }

        [Fact]
        public void TestStringWithVariable()
        {
            var expr = new Expression("x");
            expr.AddArgument("x", "hello");
            Assert.Equal("hello", expr.CalculateString());
        }

        [Fact]
        public void TestEmptyString()
        {
            Assert.Equal("", Expression.CalculateString("\"\""));
        }

        [Fact]
        public void TestArrayStringOperations()
        {
            Assert.Single(Expression.CalculateArray("Trim([ \" \",\"test\", \" \"])"));
            Assert.Equal("test", Expression.CalculateArray("Trim([ \" \",\"test\", \" \"])")[0].ToString());
        }

        [Fact]
        public void TestConcatenateStrings()
        {
            Assert.Equal("HelloWorld", Expression.CalculateString("Concat(\"Hello\", \"World\")"));
            Assert.Equal("Hello World", Expression.CalculateString("Concat(\"Hello \", \"World\")"));
        }
    }
}
