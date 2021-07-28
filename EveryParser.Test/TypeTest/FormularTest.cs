using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class FormularTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("count([1,2,3]) // max([1,2,3])"));
        }
    }
}