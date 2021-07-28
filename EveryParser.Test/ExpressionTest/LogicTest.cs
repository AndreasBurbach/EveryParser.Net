using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class LogicTest
    {
        [Fact]
        public void TestBoolean()
        {
            Assert.Equal(true, Expression.CalculateBoolean("true || false"));
            Assert.Equal(true, Expression.CalculateBoolean("false || true"));
            Assert.Equal(false, Expression.CalculateBoolean("false || false"));
            Assert.Equal(true, Expression.CalculateBoolean("true || true"));

            Assert.Equal(false, Expression.CalculateBoolean("true && false"));
            Assert.Equal(false, Expression.CalculateBoolean("false && true"));
            Assert.Equal(false, Expression.CalculateBoolean("false && false"));
            Assert.Equal(true, Expression.CalculateBoolean("true && true"));

            Assert.Equal(true, Expression.CalculateBoolean("true ^ false"));
            Assert.Equal(true, Expression.CalculateBoolean("false ^ true"));
            Assert.Equal(false, Expression.CalculateBoolean("false ^ false"));
            Assert.Equal(false, Expression.CalculateBoolean("true ^ true"));

            Assert.Equal(new object[] { true, true, false, true }, Expression.CalculateArray("[true,false, false, true] || [false,true,false, true]"));

            Assert.Equal(new object[] { false, false, false, true }, Expression.CalculateArray("[true,false, false, true] && [false,true,false, true]"));

            Assert.Equal(new object[] { true, true, false, false }, Expression.CalculateArray("[true,false, false, true] ^ [false,true,false, true]"));
        }

        [Fact]
        public void TestEqual()
        {
            Assert.Equal(true, Expression.CalculateBoolean("true == true"));
            Assert.Equal(false, Expression.CalculateBoolean("true == false"));

            Assert.Equal(true, Expression.CalculateBoolean("1 == 1"));
            Assert.Equal(false, Expression.CalculateBoolean("1 == 2"));

            Assert.Equal(true, Expression.CalculateBoolean("\"test\" == \"test\""));
            Assert.Equal(false, Expression.CalculateBoolean("\"test\" == \"not\""));

            Assert.Equal(true, Expression.CalculateBoolean("\"Test\" =i \"test\""));
            Assert.Equal(false, Expression.CalculateBoolean("\"Test\" =i \"not\""));

            Assert.Equal(false, Expression.CalculateBoolean("true != true"));
            Assert.Equal(true, Expression.CalculateBoolean("true != false"));

            Assert.Equal(false, Expression.CalculateBoolean("1 != 1"));
            Assert.Equal(true, Expression.CalculateBoolean("1 != 2"));

            Assert.Equal(false, Expression.CalculateBoolean("\"test\" != \"test\""));
            Assert.Equal(true, Expression.CalculateBoolean("\"test\" != \"not\""));

            Assert.Equal(false, Expression.CalculateBoolean("\"Test\" !=i \"test\""));
            Assert.Equal(true, Expression.CalculateBoolean("\"Test\" !=i \"not\""));
        }

        [Fact]
        public void TestContains()
        {
            Assert.Equal(true, Expression.CalculateBoolean("\"test\" in \"test\""));
            Assert.Equal(false, Expression.CalculateBoolean("\"test\" in \"not\""));

            Assert.Equal(true, Expression.CalculateBoolean("\"Test\" not in \"test\""));
            Assert.Equal(true, Expression.CalculateBoolean("\"Test\" not in \"not\""));

            Assert.Equal(true, Expression.CalculateBoolean("\"e\" in \"test\""));
            Assert.Equal(false, Expression.CalculateBoolean("\"e\" in \"not\""));

            Assert.Equal(false, Expression.CalculateBoolean("\"t\" not in \"test\""));
            Assert.Equal(true, Expression.CalculateBoolean("\"e\" not in \"not\""));

            Assert.Equal(true, Expression.CalculateBoolean("0 in [0,1,2]"));
            Assert.Equal(true, Expression.CalculateBoolean("3 not in [0,1,2]"));
        }

        [Fact]
        public void TestLowerGreater()
        {
            Assert.Equal(true, Expression.CalculateBoolean("1 >= 1"));
            Assert.Equal(true, Expression.CalculateBoolean("1 <= 1"));

            Assert.Equal(false, Expression.CalculateBoolean("1 >= 2"));
            Assert.Equal(true, Expression.CalculateBoolean("2 >= 1"));

            Assert.Equal(true, Expression.CalculateBoolean("1 <= 2"));
            Assert.Equal(false, Expression.CalculateBoolean("2 <= 1"));

            Assert.Equal(true, Expression.CalculateBoolean("1 < 2"));
            Assert.Equal(false, Expression.CalculateBoolean("2 < 1"));

            Assert.Equal(false, Expression.CalculateBoolean("1 > 2"));
            Assert.Equal(true, Expression.CalculateBoolean("2 > 1"));
        }
    }
}