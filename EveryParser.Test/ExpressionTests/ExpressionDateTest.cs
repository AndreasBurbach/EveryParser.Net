using System;
using Xunit;

namespace EveryParser.Test.ExpressionTests
{
    /// <summary>
    /// Defines to which entity of date two dates should be compared
    /// </summary>
    public enum CompareDateTime
    {
        year,
        month,
        day,
        hour,
        minute,
        second,
        millisecond
    }

    public class ExpressionDateTest
    {
        [Fact]
        public void DefaultTests()
        {
            AssertDateTime(DateTime.Now, Expression.CalculateDateTime("date_now"), CompareDateTime.second);
        }

        public static void AssertDateTime(DateTime? expected, DateTime? actual, CompareDateTime compareUpTo = CompareDateTime.millisecond)
        {
            if (expected is null)
            {
                Assert.Null(actual);
                return;
            }

            Assert.NotNull(actual);

            var enumValues = Enum.GetValues(typeof(CompareDateTime));
            foreach (var enumValue in enumValues)
            {
                if (((int)enumValue) > ((int)compareUpTo))
                    return;

                switch (enumValue)
                {
                    case CompareDateTime.year:
                        Assert.True(expected.Value.Year == actual.Value.Year, $"Year is not same for expected {expected} and actual {actual}");
                        break;
                    case CompareDateTime.month:
                        Assert.True(expected.Value.Month == actual.Value.Month, $"Month is not same for expected {expected} and actual {actual}");
                        break;
                    case CompareDateTime.day:
                        Assert.True(expected.Value.Day == actual.Value.Day, $"Day is not same for expected {expected} and actual {actual}");
                        break;
                    case CompareDateTime.hour:
                        Assert.True(expected.Value.Hour == actual.Value.Hour, $"Hour is not same for expected {expected} and actual {actual}");
                        break;
                    case CompareDateTime.minute:
                        Assert.True(expected.Value.Minute == actual.Value.Minute, $"Minute is not same for expected {expected} and actual {actual}");
                        break;
                    case CompareDateTime.second:
                        Assert.True(expected.Value.Second == actual.Value.Second, $"Second is not same for expected {expected} and actual {actual}");
                        break;
                    case CompareDateTime.millisecond:
                        Assert.True(expected.Value.Millisecond == actual.Value.Millisecond, $"Millisecond is not same for expected {expected} and actual {actual}");
                        break;
                }
            }
        }
    }
}
