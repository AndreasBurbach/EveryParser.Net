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

        [Fact]
        public void TestSimpleArithmeticTokenization()
        {
            string formula = "1 + 2 * 3";
            string[] tokens = Expression.GetFormulaTokens(formula);

            Assert.Equal(5, tokens.Length);
            Assert.Equal("1", tokens[0]);
            Assert.Equal("+", tokens[1]);
            Assert.Equal("2", tokens[2]);
            Assert.Equal("*", tokens[3]);
            Assert.Equal("3", tokens[4]);
        }

        [Fact]
        public void TestComplexExpressionTokenization()
        {
            string formula = "variable1 + (10 * func(variable2))";
            string[] tokens = Expression.GetFormulaTokens(formula);

            Assert.Equal(10, tokens.Length);
            Assert.Equal("variable1", tokens[0]);
            Assert.Equal("+", tokens[1]);
            Assert.Equal("(", tokens[2]);
            Assert.Equal("10", tokens[3]);
            Assert.Equal("*", tokens[4]);
            Assert.Equal("func", tokens[5]);
            Assert.Equal("(", tokens[6]);
            Assert.Equal("variable2", tokens[7]);
            Assert.Equal(")", tokens[8]);
            Assert.Equal(")", tokens[9]);
        }

        [Fact]
        public void TestStringTokenization()
        {
            string formula = "\"Hello\" + \" \" + \"World\"";
            string[] tokens = Expression.GetFormulaTokens(formula);

            Assert.Equal(5, tokens.Length);
            Assert.Equal("\"Hello\"", tokens[0]);
            Assert.Equal("+", tokens[1]);
            Assert.Equal("\" \"", tokens[2]);
            Assert.Equal("+", tokens[3]);
            Assert.Equal("\"World\"", tokens[4]);
        }

        [Fact]
        public void TestEmptyInput()
        {
            string formula = "";
            string[] tokens = Expression.GetFormulaTokens(formula);

            Assert.Empty(tokens);
        }

        [Fact]
        public void TestObjectPropertyAccess()
        {
            string formula = "obj.property1.subproperty";
            string[] tokens = Expression.GetFormulaTokens(formula);

            Assert.Single(tokens);
            Assert.Equal("obj.property1.subproperty", tokens[0]);
        }

        [Fact]
        public void TestNestedBracketsTokenization()
        {
            string formula = "((1 + 2) * (3 - 4))";
            string[] tokens = Expression.GetFormulaTokens(formula);

            Assert.Equal(13, tokens.Length);
            Assert.Equal("(", tokens[0]);
            Assert.Equal("(", tokens[1]);
            Assert.Equal("1", tokens[2]);
            Assert.Equal("+", tokens[3]);
            Assert.Equal("2", tokens[4]);
            Assert.Equal(")", tokens[5]);
            Assert.Equal("*", tokens[6]);
            Assert.Equal("(", tokens[7]);
            Assert.Equal("3", tokens[8]);
            Assert.Equal("-", tokens[9]);
            Assert.Equal("4", tokens[10]);
            Assert.Equal(")", tokens[11]);
            Assert.Equal(")", tokens[12]);
        }

        [Fact]
        public void TestBracketsWithFunctionCalls()
        {
            string formula = "max(min(a, b), abs(c - d))";
            string[] tokens = Expression.GetFormulaTokens(formula);

            Assert.Equal(16, tokens.Length);
            Assert.Equal("max", tokens[0]);
            Assert.Equal("(", tokens[1]);
            Assert.Equal("min", tokens[2]);
            Assert.Equal("(", tokens[3]);
            Assert.Equal("a", tokens[4]);
            Assert.Equal(",", tokens[5]);
            Assert.Equal("b", tokens[6]);
            Assert.Equal(")", tokens[7]);
            Assert.Equal(",", tokens[8]);
            Assert.Equal("abs", tokens[9]);
            Assert.Equal("(", tokens[10]);
            Assert.Equal("c", tokens[11]);
            Assert.Equal("-", tokens[12]);
            Assert.Equal("d", tokens[13]);
            Assert.Equal(")", tokens[14]);
            Assert.Equal(")", tokens[15]);
        }

        [Fact]
        public void TestBracketsInMathExpression()
        {
            string formula = "2 * (3 + 4) - 5 / (6 + 1)";
            string[] tokens = Expression.GetFormulaTokens(formula);

            Assert.Equal(15, tokens.Length);
            Assert.Equal("2", tokens[0]);
            Assert.Equal("*", tokens[1]);
            Assert.Equal("(", tokens[2]);
            Assert.Equal("3", tokens[3]);
            Assert.Equal("+", tokens[4]);
            Assert.Equal("4", tokens[5]);
            Assert.Equal(")", tokens[6]);
            Assert.Equal("-", tokens[7]);
            Assert.Equal("5", tokens[8]);
            Assert.Equal("/", tokens[9]);
            Assert.Equal("(", tokens[10]);
            Assert.Equal("6", tokens[11]);
            Assert.Equal("+", tokens[12]);
            Assert.Equal("1", tokens[13]);
            Assert.Equal(")", tokens[14]);
        }

        [Fact]
        public void TestUnmatchedBrackets()
        {
            string formula = "((1 + 2) * 3)";
            string[] tokens = Expression.GetFormulaTokens(formula);

            Assert.Equal(9, tokens.Length);
            Assert.Equal("(", tokens[0]);
            Assert.Equal("(", tokens[1]);
            Assert.Equal("1", tokens[2]);
            Assert.Equal("+", tokens[3]);
            Assert.Equal("2", tokens[4]);
            Assert.Equal(")", tokens[5]);
            Assert.Equal("*", tokens[6]);
            Assert.Equal("3", tokens[7]);
            Assert.Equal(")", tokens[8]);
        }
    }
}