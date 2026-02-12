using EveryParser.GrammarListener.TypeListener;
using Xunit;

namespace EveryParser.Test.TypeTest
{
    public class BitOperatorTest
    {
        [Fact]
        public void TestBitOr()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("5 | 3"));
        }

        [Fact]
        public void TestBitAnd()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("5 & 3"));
        }

        [Fact]
        public void TestBitShiftLeft()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("1 << 2"));
        }

        [Fact]
        public void TestBitShiftRight()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("2 >> 1"));
        }

        [Fact]
        public void TestBitwiseNot()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("~1"));
        }

        [Fact]
        public void TestBitOperatorsCombined()
        {
            Assert.Equal(EveryParserType.Number, Expression.GetPossibleResultingType("(5 | 3) & 6"));
        }
    }
}
