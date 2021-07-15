using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionArgumentTest
    {
        [Fact]
        public void TestArgumentRecognition()
        {
            string[] result = Expression.GetArgumentNames("variable1 + variable2 + objVar.variable.test");

            Assert.Equal(3, result.Length);
            Assert.Contains("variable1", result);
            Assert.Contains("variable2", result);
            Assert.Contains("objVar.variable.test", result);
        }

        [Fact]
        public void TestAddArguments()
        {
            var expr = new Expression("variable1 + variable2");

            expr.AddArgument("variable1", 1);
            expr.AddArgument("variable2", 2);

            Assert.Equal(3, expr.CalculateDecimal());

            expr = new Expression("objVar.variable1 + objVar.variable2");

            var obj = new { variable1 = 1, variable2 = 2 };

            expr.AddArgument("objVar", obj);

            Assert.Equal(3, expr.CalculateDecimal());
        }
    }
}