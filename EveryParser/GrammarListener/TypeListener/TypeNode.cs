using System.Collections.Generic;

namespace EveryParser.GrammarListener.TypeListener
{
    internal class TypeNode
    {
        public TypeNode Parent;
        public EveryParserType ValueType = EveryParserType.None;
        public List<TypeNode> Children;

        public TypeNode()
        {
        }

        public TypeNode(TypeNode parent)
        {
            Parent = parent;
        }

        public TypeNode(EveryParserType valueType)
        {
            ValueType = valueType;
        }

        public TypeNode(TypeNode parent, EveryParserType valueType)
        {
            Parent = parent;
            ValueType = valueType;
        }

        public TypeNode AddChildNode(EveryParserType value = EveryParserType.None)
        {
            if (Children is null)
                Children = new List<TypeNode>();

            var newNode = new TypeNode(this, value);
            Children.Add(newNode);
            return newNode;
        }
    }
}