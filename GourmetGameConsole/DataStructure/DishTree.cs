using GourmetGameConsole.DataStructure.Base;

namespace GourmetGameConsole.DataStructure
{
    public class DishTree : BaseTree<Dish>
    {
        public Dish LastPositiveAnswer { get; set; }
        public string Default { get; } = "Bolo de Chocolate";

        public DishTree() {
            Root = new Dish
            {
                Identifier = "Lasanha",
                Attribute = "massa",
                Left = null,
                Right = null
            };
        }
    }
}
