using EveryParser.Types;
using System.Globalization;
using Xunit;

namespace EveryParser.Test.TypesTest
{
    public class EPDecimalTest
    {
        [Fact]
        public void ConvertingTest()
        {
            var value = new EPDecimal(null);

            Assert.Equal(0, (decimal)value);
            Assert.Equal(0, (double)value);
            Assert.Equal(0, (float)value);
            Assert.Equal(0, (int)value);
            Assert.Equal(0, (long)value);

            Assert.Null((decimal?)value);
            Assert.Null((double?)value);
            Assert.Null((float?)value);
            Assert.Null((int?)value);
            Assert.Null((long?)value);

            Assert.Equal("NaN", value.ToString());

            value = new EPDecimal(12345);

            Assert.Equal(12345, (decimal)value);
            Assert.Equal(12345, (double)value);
            Assert.Equal(12345, (float)value);
            Assert.Equal(12345, (int)value);
            Assert.Equal(12345, (long)value);

            Assert.Equal(12345, (decimal?)value);
            Assert.Equal(12345, (double?)value);
            Assert.Equal(12345, (float?)value);
            Assert.Equal(12345, (int?)value);
            Assert.Equal(12345, (long?)value);

            var x = EPDecimal.ToDecimal("12345");
            Assert.Equal(12345, (decimal)x);
            Assert.Equal("12345", value.ToString());

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("en-EN", "en");
            x = EPDecimal.ToDecimal("12345.6789");
            Assert.Equal(12345.6789m, (decimal)x);

            x = EPDecimal.ToDecimal(true);
            Assert.Equal(1, (decimal)x);

            x = EPDecimal.ToDecimal(false);
            Assert.Equal(0, (decimal)x);

            x = EPDecimal.ToDecimal(new EPDecimal(12345));
            Assert.Equal(12345, (decimal)x);

            x = EPDecimal.ToDecimal(new EPDecimal(null));
            Assert.Null(x);
        }

        [Fact]
        public void ComparingTest()
        {
            var x = new EPDecimal(12345);
            var y = new EPDecimal(12345);

            Assert.Equal(x, y);
            Assert.True(x.Equals(y));
            Assert.True(x.Equals((object)y));
            Assert.True(x == y);
            Assert.False(x != y);
            Assert.Equal(x.GetHashCode(), y.GetHashCode());
            Assert.True(x >= y);
            Assert.True(x <= y);
            Assert.False(x < y);
            Assert.False(x > y);

            y = new EPDecimal(12346);

            Assert.NotEqual(x, y);
            Assert.False(x.Equals(y));
            Assert.False(x.Equals((object)y));
            Assert.False(x == y);
            Assert.True(x != y);
            Assert.NotEqual(x.GetHashCode(), y.GetHashCode());
            Assert.True(x < y);
            Assert.True(x <= y);
            Assert.True(y > x);
            Assert.True(y >= x);

            y = new EPDecimal(null);

            Assert.NotEqual(x, y);
            Assert.False(x.Equals(y));
            Assert.False(x.Equals((object)y));
            Assert.False(x == y);
            Assert.True(x != y);
            Assert.False(x > y);
            Assert.False(x >= y);
            Assert.False(y < x);
            Assert.False(y <= x);

            y = null;

            Assert.NotEqual(x, y);
            Assert.False(x.Equals(y));
            Assert.False(x.Equals((object)y));
            Assert.False(x == y);
            Assert.True(x != y);
            Assert.False(x > y);
            Assert.False(x >= y);
            Assert.False(y < x);
            Assert.False(y <= x);

            x = new EPDecimal(null);

            Assert.NotEqual(x, y);
            Assert.False(x.Equals(y));
            Assert.False(x.Equals((object)y));
            Assert.False(x == y);
            Assert.True(x != y);
            Assert.False(x > y);
            Assert.False(x >= y);
            Assert.False(y < x);
            Assert.False(y <= x);

            y = new EPDecimal(null);

            Assert.Equal(x, y);
            Assert.True(x.Equals(y));
            Assert.True(x.Equals((object)y));
            Assert.True(x == y);
            Assert.False(x != y);
            Assert.True(x >= y);
            Assert.True(x <= y);
            Assert.False(x < y);
            Assert.False(x > y);
        }
    }
}