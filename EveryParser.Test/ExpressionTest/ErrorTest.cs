using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ErrorTest
    {
        [Fact]
        public void TestParsingError()
        {
            var expr = new Expression("# + !");
            expr.Calculate();

            Assert.True(expr.HasErrors);
            Assert.Equal(2, expr.CalculationErrors.Length);

            expr.SetFormular("testfunc(1)");
            expr.Calculate();

            Assert.True(expr.HasErrors);
            Assert.Single(expr.CalculationErrors);
        }
    }
}