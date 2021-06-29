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
        All = 256,
        EmptyArray = 512,
        Array = 1024,
    }

    public static class EveryParserTypeHelper
    {
        public static bool IsNumber(this EveryParserType type) => (type & EveryParserType.Number) == EveryParserType.Number;

        public static bool IsNumberArray(this EveryParserType type) => (type & EveryParserType.ArrayOfNumber) == EveryParserType.ArrayOfNumber;

        public static bool IsNumberOrArrayOfNumbers(this EveryParserType type) => (type & (EveryParserType.Number | EveryParserType.ArrayOfNumber)) == (EveryParserType.Number | EveryParserType.ArrayOfNumber);

        public static bool IsEmptyArray(this EveryParserType type) => (type & EveryParserType.EmptyArray) == EveryParserType.EmptyArray;

    }
}