using System;

namespace EveryParser.Arguments
{
    public class DoubleArgument : BaseArgument
    {
        public DoubleArgument(string name, double value) : base(name, value)
        { }

        public override Type GetArgumentType()
        {
            return typeof(double);
        }
    }
}