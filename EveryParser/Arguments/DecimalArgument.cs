using System;

namespace EveryParser.Arguments
{
    public class DecimalArgument : BaseArgument
    {
        public DecimalArgument(string name, decimal value) : base(name, value)
        { }

        public override Type GetArgumentType()
        {
            return typeof(decimal);
        }
    }
}