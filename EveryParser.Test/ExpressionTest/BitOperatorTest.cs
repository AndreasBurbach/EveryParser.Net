using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class BitOperatorTest
    {
        [Fact]
        public void TestBitOr()
        {
            Assert.Equal(7, Expression.CalculateDecimal("5 | 3"));   // 101 | 011 = 111
            Assert.Equal(15, Expression.CalculateDecimal("12 | 7")); // 1100 | 0111 = 1111
            Assert.Equal(5, Expression.CalculateDecimal("5 | 0"));
            Assert.Equal(5, Expression.CalculateDecimal("5 | 5"));
        }

        [Fact]
        public void TestBitAnd()
        {
            Assert.Equal(1, Expression.CalculateDecimal("5 & 3"));   // 101 & 011 = 001
            Assert.Equal(4, Expression.CalculateDecimal("12 & 7"));  // 1100 & 0111 = 0100
            Assert.Equal(0, Expression.CalculateDecimal("5 & 0"));
            Assert.Equal(5, Expression.CalculateDecimal("5 & 5"));
        }

        [Fact]
        public void TestBitOrCombinedWithArithmetic()
        {
            Assert.Equal(7, Expression.CalculateDecimal("(4 + 1) | 3"));
        }

        [Fact]
        public void TestBitAndCombinedWithArithmetic()
        {
            Assert.Equal(1, Expression.CalculateDecimal("(4 + 1) & 3"));
        }

        [Fact]
        public void TestBitShiftLeftBasic()
        {
            Assert.Equal(2, Expression.CalculateDecimal("1 << 1"));
            Assert.Equal(4, Expression.CalculateDecimal("1 << 2"));
            Assert.Equal(8, Expression.CalculateDecimal("1 << 3"));
            Assert.Equal(1024, Expression.CalculateDecimal("1 << 10"));
        }

        [Fact]
        public void TestBitShiftRightBasic()
        {
            Assert.Equal(1, Expression.CalculateDecimal("2 >> 1"));
            Assert.Equal(1, Expression.CalculateDecimal("4 >> 2"));
            Assert.Equal(1, Expression.CalculateDecimal("8 >> 3"));
            Assert.Equal(1, Expression.CalculateDecimal("1024 >> 10"));
        }

        [Fact]
        public void TestBitShiftWithZero()
        {
            Assert.Equal(5, Expression.CalculateDecimal("5 << 0"));
            Assert.Equal(5, Expression.CalculateDecimal("5 >> 0"));
        }

        [Fact]
        public void TestBitOperatorsCombined()
        {
            // (5 | 3) & 6 → 7 & 6 → 6
            Assert.Equal(6, Expression.CalculateDecimal("(5 | 3) & 6"));
        }

        [Fact]
        public void TestBitwiseNot()
        {
            Assert.Equal(~1, Expression.CalculateDecimal("~1"));
            Assert.Equal(~0, Expression.CalculateDecimal("~0"));
            Assert.Equal(~255, Expression.CalculateDecimal("~255"));
        }
    }
}
