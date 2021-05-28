using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionArgumentTest
    {
        [Fact]
        public void Test1()
        {
            new Expression().AddArgument("Test", new string[0]);
            Assert.Equal("", "");
        }
    }
}