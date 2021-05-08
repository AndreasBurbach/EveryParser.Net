using System;

namespace EveryParser.Arguments
{
    public class IntegerArgument : BaseArgument
    {
        public IntegerArgument(string name, int value) : base(name, value)
        { }

        public override Type GetArgumentType()
        {
            return typeof(int);
        }
    }
}