using System;

namespace EveryParser
{
    public abstract class BaseArgument
    {
        public string Name => _name;

        protected object _value;
        protected readonly string _name;

        public BaseArgument(string name, object value)
        {
            _name = name;
            _value = value;
        }

        public virtual Type GetArgumentType()
        {
            return typeof(object);
        }
    }
}