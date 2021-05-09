namespace GourmetGameConsole.DataStructure.Interfaces
{
    public interface INode<T>
    {
        public string Identifier { get; set; }
        public string Attribute { get; set; }
        public T Left { get; set; }
        public T Right { get; set; }
    }
}
