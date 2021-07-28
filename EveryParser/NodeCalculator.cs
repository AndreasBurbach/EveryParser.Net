using System.Collections.Generic;

namespace EveryParser
{
    internal class NodeCalculator
    {
        public NodeCalculator Parent;
        public int Index;
        public object Value;
        public List<NodeCalculator> Children;

        public NodeCalculator()
        {
        }

        public NodeCalculator(NodeCalculator parent, int index)
        {
            Parent = parent;
            Index = index;
        }

        public NodeCalculator(object value)
        {
            Value = value;
        }

        public NodeCalculator(NodeCalculator parent, int index, object value)
        {
            Parent = parent;
            Index = index;
            Value = value;
        }

        public NodeCalculator AddChildNode(object value = null)
        {
            if (Children is null)
                Children = new List<NodeCalculator>();

            var newNode = new NodeCalculator(this, Children.Count, value);
            Children.Add(newNode);
            return newNode;
        }
    }
}