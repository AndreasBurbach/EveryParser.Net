using System;

namespace EveryParser.Arguments
{
    public class StringArgument : BaseArgument
    {
        public StringArgument(string name, string value) : base(name, value)
        { }

        public override Type GetArgumentType()
        {
            return typeof(string);
        }
    }
}