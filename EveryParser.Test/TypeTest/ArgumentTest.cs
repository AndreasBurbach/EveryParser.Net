using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class ArgumentTest
    {
        [Fact]
        public void TestAddArguments()
        {
            var expr = new Expression("variable1 + variable2");

            expr.AddArgument("variable1", 1);
            expr.AddArgument("variable2", 2);

            Assert.Equal(EveryParserType.Number, expr.GetPossibleResultingType());

            expr = new Expression("objVar.variable1 + objVar.variable2");

            var obj = new { variable1 = 1, variable2 = 2 };

            expr.AddArgument("objVar", obj);

            Assert.Equal(EveryParserType.Number, expr.GetPossibleResultingType());
        }
    }
}