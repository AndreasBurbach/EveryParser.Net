using System;

namespace EveryParser.Arguments
{
    public class BooleanArgument : BaseArgument
    {
        public BooleanArgument(string name, bool value) : base(name, value)
        { }

        public override Type GetArgumentType()
        {
            return typeof(bool);
        }
    }
}