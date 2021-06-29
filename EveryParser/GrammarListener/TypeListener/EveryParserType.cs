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
}