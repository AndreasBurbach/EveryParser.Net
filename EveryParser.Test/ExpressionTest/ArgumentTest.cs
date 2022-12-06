using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ArgumentTest
    {
        [Fact]
        public void TestArgumentRecognition()
        {
            string[] result = Expression.GetFormularArgumentNames("variable1 + variable2 + objVar.variable.test");

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

        [Fact]
        public void TestNonExistingArguments()
        {
            var expr = new Expression("variable1 + variable2");

            expr.AddArgument("variable1", 1);

            expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.Equal(2, expr.CalculationErrors.Length);

            expr = new Expression("KpiValue_17 - KpiValue_33 + KpiValue_34 + KpiValue_12 + KpiValue_35 - KpiValue_36");

            expr.AddArgument("KpiValue_12", 1406.08);
            expr.AddArgument("KpiValue_17", -20904.63);
            expr.AddArgument("KpiValue_35", 3620.84);
            expr.AddArgument("KpiValue_36", 40000);

            expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.Equal(4, expr.CalculationErrors.Length);
        }
    }
}