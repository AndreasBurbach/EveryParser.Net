using System;

namespace EveryParser.Types
{
    public class EPDecimal
    {
        public decimal? Value { get; set; }

        public bool IsNaN => Value is null;

        public EPDecimal() => Value = 0;

        public EPDecimal(decimal? value) => Value = value;

        public EPDecimal(object value) => Value = ToDecimal(value);

        public decimal GetValue() => Value ?? 0;

        public static EPDecimal ToEPDecimal(decimal? value) => new EPDecimal(value);

        public static EPDecimal ToEPDecimal(object value) => new EPDecimal(value);

        public static EPDecimal operator +(EPDecimal x) => new EPDecimal(x.IsNaN ? null : +x.Value);

        public static EPDecimal operator -(EPDecimal x) => new EPDecimal(x.IsNaN ? null : -x.Value);

        public static EPDecimal operator +(EPDecimal x, EPDecimal y) => new EPDecimal(x.IsNaN || y.IsNaN ? null : x.Value + y.Value);

        public static EPDecimal operator -(EPDecimal x, EPDecimal y) => new EPDecimal(x.IsNaN || y.IsNaN ? null : x.Value - y.Value);

        public static EPDecimal operator *(EPDecimal x, EPDecimal y) => new EPDecimal(x.IsNaN || y.IsNaN ? null : x.Value * y.Value);

        public static EPDecimal operator /(EPDecimal x, EPDecimal y) => new EPDecimal(x.IsNaN || y.IsNaN ? null : x.Value / y.Value);

        public static EPDecimal operator %(EPDecimal x, EPDecimal y) => new EPDecimal(x.IsNaN || y.IsNaN ? null : x.Value % y.Value);

        public static EPDecimal operator --(EPDecimal x) => new EPDecimal(x.IsNaN ? null : x.Value - 1);

        public static EPDecimal operator ~(EPDecimal x) => new EPDecimal(x.IsNaN ? null : (decimal?)(~Convert.ToInt64(x.Value)));

        public static EPDecimal operator !(EPDecimal x) => new EPDecimal(x.IsNaN ? null : (decimal?)(Convert.ToInt64(x.Value) == 0 ? 1 : 0));

        public static EPDecimal operator &(EPDecimal x, EPDecimal y) => new EPDecimal(x.IsNaN || y.IsNaN ? null : (decimal?)(Convert.ToInt64(x.Value) & Convert.ToInt64(y.Value)));

        public static EPDecimal operator |(EPDecimal x, EPDecimal y) => new EPDecimal(x.IsNaN || y.IsNaN ? null : (decimal?)(Convert.ToInt64(x.Value) | Convert.ToInt64(y.Value)));

        public static EPDecimal operator ^(EPDecimal x, EPDecimal y) => new EPDecimal(x.IsNaN || y.IsNaN ? null : (decimal?)(Convert.ToInt64(x.Value) ^ Convert.ToInt64(y.Value)));

        public static EPDecimal operator <<(EPDecimal x, int y) => new EPDecimal(x.IsNaN ? null : (decimal?)(Convert.ToInt64(x.Value) << y));

        public static EPDecimal operator >>(EPDecimal x, int y) => new EPDecimal(x.IsNaN ? null : (decimal?)(Convert.ToInt64(x.Value) >> y));

        public static bool operator ==(EPDecimal x, EPDecimal y) => x.IsNaN || y.IsNaN ? false : x.Value == y.Value;

        public static bool operator !=(EPDecimal x, EPDecimal y) => x.IsNaN || y.IsNaN ? true : x.Value != y.Value;

        public static bool operator <(EPDecimal x, EPDecimal y) => x.IsNaN || y.IsNaN ? false : x.Value < y.Value;

        public static bool operator >(EPDecimal x, EPDecimal y) => x.IsNaN || y.IsNaN ? false : x.Value > y.Value;

        public static bool operator <=(EPDecimal x, EPDecimal y) => x.IsNaN || y.IsNaN ? false : x.Value <= y.Value;

        public static bool operator >=(EPDecimal x, EPDecimal y) => x.IsNaN || y.IsNaN ? false : x.Value >= y.Value;

        public static EPDecimal operator ++(EPDecimal x) => new EPDecimal(x.IsNaN ? null : x.Value + 1);

        public static implicit operator EPDecimal(decimal? value) => new EPDecimal(value);

        public static implicit operator EPDecimal(int? value) => new EPDecimal(value);

        public static implicit operator EPDecimal(long? value) => new EPDecimal(value);

        public static implicit operator EPDecimal(double? value) => new EPDecimal(value);

        public static implicit operator EPDecimal(float? value) => new EPDecimal(value);

        public static implicit operator EPDecimal(string value) => new EPDecimal(value);

        public static implicit operator EPDecimal(bool value) => new EPDecimal(value);

        public static implicit operator decimal?(EPDecimal value) => value.Value;

        public static implicit operator double?(EPDecimal value) => value.IsNaN ? null : (double?)Convert.ToDouble(value.Value);

        public static implicit operator float?(EPDecimal value) => value.IsNaN ? null : (float?)Convert.ToSingle(value.Value);

        public static implicit operator int?(EPDecimal value) => value.IsNaN ? null : (int?)Convert.ToInt32(value.Value);

        public static implicit operator long?(EPDecimal value) => value.IsNaN ? null : (long?)Convert.ToInt64(value.Value);

        public static implicit operator decimal(EPDecimal value) => value.Value??0;

        public static implicit operator double(EPDecimal value) => value.IsNaN ? 0 : (double)(value.Value??0);

        public static implicit operator float(EPDecimal value) => value.IsNaN ? 0 : (float)(value.Value??0);

        public static implicit operator int(EPDecimal value) => value.IsNaN ? 0 : (int)(value.Value??0);

        public static implicit operator long(EPDecimal value) => value.IsNaN ? 0 : (long)(value.Value??0);

        public override bool Equals(object obj) => obj is EPDecimal objVal && Equals(objVal);

        public bool Equals(EPDecimal obj) => obj == this;

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => IsNaN ? "NaN" : Value.ToString();

        private static object ToDecimalWithNaN(object value)
        {
            if (value is null)
                return double.NaN;

            if (value is EPDecimal epDecimal)
                if (epDecimal.IsNaN)
                    return double.NaN;
                else
                    return epDecimal.Value;

            if (value is decimal)
                return value;

            if (value is double)
                if (double.IsNaN((double)value) || double.IsInfinity((double)value))
                    return double.NaN;
                else
                    return (decimal)(double)value;

            if (value is float)
                if (float.IsNaN((float)value) || float.IsInfinity((float)value))
                    return double.NaN;
                else
                    return (decimal)(float)value;

            if (value is long)
                return (decimal)(long)value;

            if (value is int)
                return (decimal)(int)value;
            if (value is short)
                return (decimal)(short)value;
            if (value is byte)
                return (decimal)(byte)value;
            if (value is ulong)
                return (decimal)(ulong)value;
            if (value is uint)
                return (decimal)(uint)value;
            if (value is ushort)
                return (decimal)(ushort)value;
            if (value is sbyte)
                return (decimal)(sbyte)value;
            if (value is bool bValue)
                return (decimal)(bValue ? 1 : 0);

            if (decimal.TryParse(value.ToString(), out decimal result))
                return result;

            return double.NaN;
        }

        public static decimal? ToDecimal(object value)
        {
            var result = ToDecimalWithNaN(value);

            if (result is double && double.IsNaN((double)result))
                return null;

            return (decimal)result;
        }
    }
}