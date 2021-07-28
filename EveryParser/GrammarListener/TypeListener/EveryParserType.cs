using System;

namespace EveryParser.GrammarListener.TypeListener
{
    [Flags]
    public enum EveryParserType
    {
        None = 0,
        Number = 1,
        Boolean = 2,
        String = 4,
        DateTime = 8,
        ArrayOfNumber = 16,
        ArrayOfBoolean = 32,
        ArrayOfString = 64,
        ArrayOfDateTime = 128,
        EmptyArray = 256,
        Array = 512,
    }

    public static class EveryParserTypeHelper
    {
        public static bool IsNumber(this EveryParserType type) => (type & EveryParserType.Number) == EveryParserType.Number;

        public static bool IsNumberArray(this EveryParserType type) => (type & EveryParserType.ArrayOfNumber) == EveryParserType.ArrayOfNumber;

        public static bool IsNumberOrArrayOfNumbers(this EveryParserType type) => (type & (EveryParserType.Number | EveryParserType.ArrayOfNumber)) == (EveryParserType.Number | EveryParserType.ArrayOfNumber);

        public static bool IsEmptyArray(this EveryParserType type) => (type & EveryParserType.EmptyArray) == EveryParserType.EmptyArray;

        public static bool IsArray(this EveryParserType type) => (type & EveryParserType.Array) == EveryParserType.Array;

        public static bool IsString(this EveryParserType type) => (type & EveryParserType.String) == EveryParserType.String;

        public static bool IsStringArray(this EveryParserType type) => (type & EveryParserType.ArrayOfString) == EveryParserType.ArrayOfString;

        public static bool IsStringOrArrayOfStrings(this EveryParserType type) => (type & (EveryParserType.String | EveryParserType.ArrayOfString)) == (EveryParserType.String | EveryParserType.ArrayOfString);

        public static bool IsArrayType(this EveryParserType type)
        {
            switch (type)
            {
                case EveryParserType.ArrayOfNumber:
                case EveryParserType.ArrayOfBoolean:
                case EveryParserType.ArrayOfString:
                case EveryParserType.ArrayOfDateTime:
                case EveryParserType.EmptyArray:
                case EveryParserType.Array:
                    return true;
            }

            return false;
        }

        public static bool IsBoolean(this EveryParserType type) => (type & EveryParserType.Boolean) == EveryParserType.Boolean;

        public static bool IsBooleanArray(this EveryParserType type) => (type & EveryParserType.ArrayOfBoolean) == EveryParserType.ArrayOfBoolean;

        public static bool IsDateTime(this EveryParserType type) => (type & EveryParserType.DateTime) == EveryParserType.DateTime;
    }
}