using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ErrorHandlingTest
    {
        [Fact]
        public void TestParsingErrorBasic()
        {
            var expr = new Expression("# + !");
            expr.Calculate();

            Assert.True(expr.HasErrors);
            Assert.True(expr.CalculationErrors.Length > 0);
        }

        [Fact]
        public void TestUnknownFunction()
        {
            var expr = new Expression("testfunc(1)");
            expr.Calculate();

            Assert.True(expr.HasErrors);
            Assert.Single(expr.CalculationErrors);
        }

        [Fact]
        public void TestMissingClosingBracket()
        {
            var expr = new Expression("(1 + 2");
            expr.Calculate();

            Assert.True(expr.HasErrors);
        }

        [Fact]
        public void TestMissingOpeningBracket()
        {
            // Parser tolerates trailing closing bracket, result is still computed
            var expr = new Expression("1 + 2)");
            var result = expr.Calculate();

            // The parser does not flag this as an error
            Assert.False(expr.HasErrors);
            Assert.Equal(3m, result);
        }

        [Fact]
        public void TestUndefinedVariable()
        {
            var expr = new Expression("unknownVar + 1");
            expr.Calculate();

            Assert.True(expr.HasErrors);
        }

        [Fact]
        public void TestMultipleUndefinedVariables()
        {
            var expr = new Expression("a + b + c");
            expr.Calculate();

            Assert.True(expr.HasErrors);
            Assert.True(expr.CalculationErrors.Length >= 3);
        }

        [Fact]
        public void TestInvalidExpression()
        {
            var expr = new Expression("+++");
            expr.Calculate();

            Assert.True(expr.HasErrors);
        }

        [Fact]
        public void TestOnlyOperator()
        {
            var expr = new Expression("+");
            expr.Calculate();

            Assert.True(expr.HasErrors);
        }

        [Fact]
        public void TestPartiallyDefinedVariables()
        {
            var expr = new Expression("a + b");
            expr.AddArgument("a", 1);

            expr.Calculate();

            Assert.True(expr.HasErrors);
        }

        [Fact]
        public void TestErrorsClearedAfterValidCalculation()
        {
            var expr = new Expression("unknownVar + 1");
            expr.Calculate();
            Assert.True(expr.HasErrors);

            expr.SetFormular("1 + 1");
            expr.Calculate();
            Assert.False(expr.HasErrors);
        }

        [Fact]
        public void TestErrorsClearedBetweenCalculations()
        {
            var expr = new Expression("a + 1");

            // First: error
            expr.Calculate();
            Assert.True(expr.HasErrors);

            // Add argument, recalculate
            expr.AddArgument("a", 5);
            expr.Calculate();
            Assert.False(expr.HasErrors);
            Assert.Equal(6m, expr.CalculateDecimal());
        }

        [Fact]
        public void TestDivisionByZeroThrowsException()
        {
            // Division by zero throws DivideByZeroException (not caught by parser)
            Assert.ThrowsAny<System.DivideByZeroException>(() => Expression.CalculateDecimal("1 / 0"));
        }

        [Fact]
        public void TestIntegerDivisionByZeroThrowsException()
        {
            Assert.ThrowsAny<System.DivideByZeroException>(() =>
            {
                var expr = new Expression("1 // 0");
                expr.Calculate();
            });
        }

        [Fact]
        public void TestModuloByZeroThrowsException()
        {
            Assert.ThrowsAny<System.DivideByZeroException>(() =>
            {
                var expr = new Expression("10 % 0");
                expr.Calculate();
            });
        }

        [Fact]
        public void TestEmptyArrayOperations()
        {
            Assert.Equal(0, Expression.CalculateDecimal("Count([])"));
        }

        [Fact]
        public void TestConsecutiveErrorsDoNotAccumulate()
        {
            var expr = new Expression("unknownVar");

            expr.Calculate();
            var errCount1 = expr.CalculationErrors.Length;

            expr.Calculate();
            var errCount2 = expr.CalculationErrors.Length;

            Assert.Equal(errCount1, errCount2);
        }
    }
}
