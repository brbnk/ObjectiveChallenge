using GourmetGameConsole.DataStructure.Interfaces;

namespace GourmetGameConsole.DataStructure
{
    public class Dish : INode<Dish>
    {
        public string Identifier { get; set; }
        public string Attribute { get; set; }
        public Dish Left { get; set; }
        public Dish Right { get; set; }
    }
}
