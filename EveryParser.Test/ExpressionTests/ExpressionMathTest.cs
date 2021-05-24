using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionMathTest
    {


        [Fact]
        public void DefaultTests()
        {
            Assert.Equal(1 + 0, Expression.CalculatePrimitiveDecimal("1+0"));
            Assert.Equal(125 + 375, Expression.CalculatePrimitiveDecimal("125 + 375"));
            Assert.Equal(15.25m + 7.90m + 3.12m, Expression.CalculatePrimitiveDecimal("15.25 + 7.90 + 3.12"));
            Assert.Equal(1200 - 450, Expression.CalculatePrimitiveDecimal("1200 - 450"));
            Assert.Equal(10 - 9 + 8 - 7 + 6 - 5 + 4 - 3 + 2 - 1, Expression.CalculatePrimitiveDecimal("10 - 9 + 8 - 7 + 6 - 5 + 4 - 3 + 2 - 1"));
            Assert.Equal(1.05m * 12m, Expression.CalculatePrimitiveDecimal("1.05 * 12,000"));
            Assert.Equal(125 * 216 * 343, Expression.CalculatePrimitiveDecimal("125 * 216 * 343"));
            Assert.Equal(1000 / 65, Expression.CalculatePrimitiveDecimal("1000 // 65"));
            Assert.Equal(13.5m / 18.27m, Expression.CalculatePrimitiveDecimal("13.5 / 18.27"));
            Assert.Equal((2 * 3 + 3 * 4 + 4 * 5) / (10 - 5), Expression.CalculatePrimitiveDecimal("(2*3 + 3*4 + 4*5) // (10 - 5)"));
            Assert.Equal(1 + ((2 * 3 + 3 * 4 + 4 * 5) / ((10 - 5) * 5)), Expression.CalculatePrimitiveDecimal("1+ ((2*3 + 3*4 + 4*5) // ((10 - 5) * 5))"));
            Assert.Equal(1 + 1 * 3, Expression.CalculatePrimitiveDecimal("1+1*3"));
            Assert.Equal(42, Expression.CalculatePrimitiveDecimal("42"));
            Assert.Equal((1 + 1), Expression.CalculatePrimitiveDecimal("(1+1)"));
            Assert.Equal((1 + 1) / (3), Expression.CalculatePrimitiveDecimal("(1+1)//(3)"));
        }

        [Fact]
        public void FactorTests()
        {
            Assert.Equal(-1, Expression.CalculatePrimitiveDecimal("-1"));
            Assert.Equal(~1, Expression.CalculatePrimitiveDecimal("~1"));
            Assert.Equal(+1, Expression.CalculatePrimitiveDecimal("+1"));
        }

        [Fact]
        public void FunctionTests()
        {
            Assert.Equal(1, Expression.CalculatePrimitiveDecimal("Min([1,2,3,4,5.5])"));
            Assert.Equal(5.5m, Expression.CalculatePrimitiveDecimal("Max([1,2,3,4,5.5])"));
            Assert.Equal(1, Expression.CalculatePrimitiveDecimal("sqrt(1)"));
            Assert.Equal(10, Expression.CalculatePrimitiveDecimal("sqrt(100)"));
            //Assert.Equal(new decimal[] { 10, 1, 2 }, Expression.CalculatePrimitiveDecimal("sqrt([100,1,4])"));
            //Assert.Equal(new decimal[] { 100, 1, 4 }, Expression.CalculatePrimitiveDecimal("abs([-100,-1,4])"));
            Assert.Equal(1, Expression.CalculatePrimitiveDecimal("abs(1)"));
            Assert.Equal(-1, Expression.CalculatePrimitiveDecimal("abs(-1)"));
            Assert.Equal(1, Expression.CalculatePrimitiveDecimal("pow(1,1)"));
        }
    }
}