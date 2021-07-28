using System;
using System.Globalization;
using Xunit;

namespace EveryParser.Test.ExpressionTest
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

    public class DateTest
    {
        [Fact]
        public void DefaultTests()
        {
            var nowActual = Expression.CalculateDateTime("DateTime.Now");
            var nowExpected = DateTime.Now;

            AssertDateTime(nowExpected, nowActual, CompareDateTime.second); //for comparing milliseconds the programm is too slow :-|

            AssertDateTime(nowExpected, Expression.CalculateDateTime($"DateTime(\"{nowExpected.ToString(CultureInfo.InvariantCulture)}\")"), CompareDateTime.second);
            Assert.Equal(new object[] { DateTime.Parse(nowExpected.ToString(CultureInfo.InvariantCulture), CultureInfo.InvariantCulture),
                DateTime.Parse(nowExpected.ToString(CultureInfo.InvariantCulture), CultureInfo.InvariantCulture) },
                Expression.CalculateArray($"DateTime([\"{nowExpected.ToString(CultureInfo.InvariantCulture)}\",\"{nowExpected.ToString(CultureInfo.InvariantCulture)}\"])"));

            AssertDateTime(new DateTime(2021, 2, 3), Expression.CalculateDateTime("DateTime(2021,2,3)"), CompareDateTime.day);
            AssertDateTime(new DateTime(2021, 2, 3, 4, 0, 0), Expression.CalculateDateTime("DateTime(2021,2,3,4)"), CompareDateTime.second);
            AssertDateTime(new DateTime(2021, 2, 3, 4, 5, 0), Expression.CalculateDateTime("DateTime(2021,2,3,4,5)"), CompareDateTime.second);
            AssertDateTime(new DateTime(2021, 2, 3, 4, 5, 6), Expression.CalculateDateTime("DateTime(2021,2,3,4,5,6)"), CompareDateTime.second);
            AssertDateTime(new DateTime(2021, 2, 3, 4, 5, 6, 7), Expression.CalculateDateTime("DateTime(2021,2,3,4,5,6,7)"), CompareDateTime.millisecond);

            Assert.Equal(new object[] { new DateTime(2021, 2, 3, 4, 5, 6, 1), new DateTime(2021, 2, 3, 4, 5, 6, 2) }, Expression.CalculateArray("DateTime(2021,2,3,4,5,6,[1,2])"));
        }

        private void AssertDateTime(DateTime? expected, DateTime? actual, CompareDateTime compareUpTo = CompareDateTime.millisecond)
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
                        Assert.True(expected.Value.Year == actual.Value.Year, $"Year is not same for expected {expected.ToAssertDateTimeString()} and actual {actual.ToAssertDateTimeString()}");
                        break;

                    case CompareDateTime.month:
                        Assert.True(expected.Value.Month == actual.Value.Month, $"Month is not same for expected {expected.ToAssertDateTimeString()} and actual {actual.ToAssertDateTimeString()}");
                        break;

                    case CompareDateTime.day:
                        Assert.True(expected.Value.Day == actual.Value.Day, $"Day is not same for expected {expected.ToAssertDateTimeString()} and actual {actual.ToAssertDateTimeString()}");
                        break;

                    case CompareDateTime.hour:
                        Assert.True(expected.Value.Hour == actual.Value.Hour, $"Hour is not same for expected {expected.ToAssertDateTimeString()} and actual {actual.ToAssertDateTimeString()}");
                        break;

                    case CompareDateTime.minute:
                        Assert.True(expected.Value.Minute == actual.Value.Minute, $"Minute is not same for expected {expected.ToAssertDateTimeString()} and actual {actual.ToAssertDateTimeString()}");
                        break;

                    case CompareDateTime.second:
                        Assert.True(expected.Value.Second == actual.Value.Second, $"Second is not same for expected {expected.ToAssertDateTimeString()} and actual {actual.ToAssertDateTimeString()}");
                        break;

                    case CompareDateTime.millisecond:
                        Assert.True(expected.Value.Millisecond == actual.Value.Millisecond, $"Millisecond is not same for expected {expected.ToAssertDateTimeString()} and actual {actual.ToAssertDateTimeString()}");
                        break;
                }
            }
        }
    }

    public static class DateTimeExtension
    {
        public static string ToAssertDateTimeString(this DateTime? dateTime)
        {
            return dateTime.HasValue ? dateTime.Value.ToString("dd.MM.yyyy hh:mm:ss.fff tt") : "null";
        }
    }
}