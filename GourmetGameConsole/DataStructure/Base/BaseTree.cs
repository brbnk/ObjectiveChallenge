using GourmetGameConsole.DataStructure.Interfaces;

namespace GourmetGameConsole.DataStructure.Base
{
    public class BaseTree<T> where T : INode<T>, new()
    {
        public T Root { get; set; }

        public bool NodeHasLeft(T node) => node.Left != null;
        public bool NodeHasRight(T node) => node.Right != null;

        public T NewNode(string identifier, string attribute)
        {
            var instance = new T
            {
                Identifier = identifier,
                Attribute = attribute,
                Left = default,
                Right = default
            };

            return instance;
        }

        public void AddNodeToLeft(T node, T leftNode)
        {
            node.Left = leftNode;
        }

        public void AddNodeToRight(T node, T rightNode)
        {
            node.Right = rightNode;
        }
    }
}
