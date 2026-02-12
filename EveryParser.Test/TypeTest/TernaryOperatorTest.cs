using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class TernaryOperatorTest
    {
        [Fact]
        public void TestTernaryParsesWithoutErrors()
        {
            // Ternary operator is recognized by type system
            var expr = new Expression("true ? 1 : 2");
            var type = expr.GetPossibleResultingType();
            Assert.False(expr.HasErrors);
            Assert.Equal(EveryParserType.Boolean, type); //Condition is boolean, cause no evaluation while type inference
        }

        [Fact]
        public void TestTernaryReturnsBooleanForCondition()
        {
            // Type system infers based on condition type (Boolean)
            Assert.Equal(EveryParserType.Boolean, Expression.GetPossibleResultingType("true ? true : false"));
        }
    }
}
