using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class TernaryOperatorTest
    {
        [Fact]
        public void TestTernaryTrueReturnsFirstBranch()
        {
            // Ternary with true condition returns first branch value
            Assert.Equal(1, Expression.CalculateDecimal("true ? 1 : 2"));
        }

        [Fact]
        public void TestTernaryParsesSyntactically()
        {
            // Ternary is parsed without errors
            var expr = new Expression("true ? 1 : 2");
            expr.Calculate();
            Assert.False(expr.HasErrors);

            expr = new Expression("false ? 1 : 2");
            expr.Calculate();
            Assert.False(expr.HasErrors);
        }

        [Fact]
        public void TestTernaryBooleanConditionParsesWithoutError()
        {
            var expr = new Expression("true ? true : false");
            var result = expr.CalculateBoolean();
            Assert.False(expr.HasErrors);
            Assert.NotNull(result);
            Assert.True(result.Value);
        }

        [Fact]
        public void TestTernaryWithLogicalConditionInBrackets()
        {
            var expr = new Expression("(true && true) ? 1 : 0");
            var result = expr.CalculateDecimal();
            Assert.False(expr.HasErrors);
            Assert.Equal(1, result);

            expr = new Expression("(true || false) ? 1 : 0");
            result = expr.CalculateDecimal();
            Assert.False(expr.HasErrors);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestTernaryResultIsNotNull()
        {
            Assert.NotNull(Expression.Calculate("true ? 1 : 2"));
            Assert.NotNull(Expression.Calculate("false ? 1 : 2"));
        }
    }
}
