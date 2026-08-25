using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class AsyncTest
    {
        [Fact]
        public async Task TestCalculateAsync()
        {
            var expr = new Expression("1 + 2");
            var result = await expr.CalculateAsync();

            Assert.Equal(3m, result);
        }

        [Fact]
        public async Task TestCalculateDecimalAsync()
        {
            var expr = new Expression("1.5 * 2");
            Assert.Equal(3m, await expr.CalculateDecimalAsync());
        }

        [Fact]
        public async Task TestCalculateBooleanAsync()
        {
            var expr = new Expression("true && false");
            Assert.False(await expr.CalculateBooleanAsync());
        }

        [Fact]
        public async Task TestCalculateStringAsync()
        {
            var expr = new Expression("Concat(\"Hello \", \"World\")");
            Assert.Equal("Hello World", await expr.CalculateStringAsync());
        }

        [Fact]
        public async Task TestCalculateDateTimeAsync()
        {
            var expr = new Expression("DateTime(2020, 1, 2)");
            Assert.Equal(new DateTime(2020, 1, 2), await expr.CalculateDateTimeAsync());
        }

        [Fact]
        public async Task TestCalculateArrayAsync()
        {
            var expr = new Expression("[1, 2, 3]");
            Assert.Equal(new object[] { 1L, 2L, 3L }, await expr.CalculateArrayAsync());
        }

        [Fact]
        public async Task TestStaticCalculateDecimalAsync()
        {
            Assert.Equal(6m, await Expression.CalculateDecimalAsync("2 * 3"));
        }

        [Fact]
        public async Task TestStaticCalculateAsync()
        {
            Assert.Equal(4m, await Expression.CalculateAsync("2 + 2"));
        }

        [Fact]
        public async Task TestErrorsAreSetAfterAsyncCalculation()
        {
            var expr = new Expression("unknownVar + 1");
            var result = await expr.CalculateAsync();

            Assert.Null(result);
            Assert.True(expr.HasErrors);
        }

        [Fact]
        public async Task TestArgumentsAreUsedInAsyncCalculation()
        {
            var expr = new Expression("a + b");
            expr.AddArgument("a", 1);
            expr.AddArgument("b", 2);

            Assert.Equal(3m, await expr.CalculateDecimalAsync());
        }

        [Fact]
        public async Task TestCancelledTokenThrowsOperationCanceledException()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();

            await Assert.ThrowsAnyAsync<OperationCanceledException>(
                () => new Expression("1 + 1").CalculateAsync(cts.Token));
        }
    }
}