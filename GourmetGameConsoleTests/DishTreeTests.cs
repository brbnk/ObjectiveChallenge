using Microsoft.VisualStudio.TestTools.UnitTesting;
using GourmetGameConsole.DataStructure;

namespace GoutmetGameConsoleTests
{
    [TestClass]
    public class DishTreeTests
    {
        [TestMethod]
        public void DefaultDishOfTreeTest()
        {
            var dishTree = new DishTree();

            var defaultDish = dishTree.Default;

            var expected = "Bolo de Chocolate";

            Assert.AreEqual(expected, defaultDish);
        }

        [TestMethod]
        public void RootOfDishTreeTest()
        {
            var dishTree = new DishTree();

            var expected = new Dish
            {
                Attribute = "massa",
                Identifier = "Lasanha",
                Left = null,
                Right = null
            };

            Assert.AreEqual(expected.Attribute, dishTree.Root.Attribute);
            Assert.AreEqual(expected.Identifier, dishTree.Root.Identifier);
            Assert.AreEqual(expected.Left, dishTree.Root.Left);
            Assert.AreEqual(expected.Right, dishTree.Root.Right);
        }

        [TestMethod]
        public void AddNewNodeTest()
        {
            var dishTree = new DishTree();

            var expected = new Dish
            {
                Attribute = "doce",
                Identifier = "Sorvete",
                Left = null,
                Right = null
            };

            var returned = dishTree.NewNode("Sorvete", "doce");

            Assert.AreEqual(expected.GetType(), returned.GetType());
            Assert.AreEqual(expected.Attribute, returned.Attribute);
            Assert.AreEqual(expected.Identifier, returned.Identifier);
            Assert.AreEqual(expected.Left, returned.Left);
            Assert.AreEqual(expected.Right, returned.Right);
        }

        [TestMethod]
        public void AddNodeToLeftTest()
        {
            var dishTree = new DishTree();

            var expected = new Dish
            {
                Attribute = "doce",
                Identifier = "Sorvete",
                Left = null,
                Right = null
            };

            dishTree.AddNodeToLeft(dishTree.Root, expected);

            Assert.IsNotNull(dishTree.Root.Left);
            Assert.IsNull(dishTree.Root.Right);
        }

        [TestMethod]
        public void AddNodeToRightTest()
        {
            var dishTree = new DishTree();

            var expected = new Dish
            {
                Attribute = "doce",
                Identifier = "Sorvete",
                Left = null,
                Right = null
            };

            dishTree.AddNodeToRight(dishTree.Root, expected);

            Assert.IsNotNull(dishTree.Root.Right);
            Assert.IsNull(dishTree.Root.Left);
        }

        [TestMethod]
        public void CheckIfNodeHasLeftChild()
        {
            var dishTree = new DishTree();

            var expected = new Dish
            {
                Attribute = "doce",
                Identifier = "Sorvete",
                Left = null,
                Right = null
            };

            dishTree.AddNodeToLeft(dishTree.Root, expected);

            Assert.IsTrue(dishTree.NodeHasLeft(dishTree.Root));
        }

        [TestMethod]
        public void CheckIfNodeHasRightChild()
        {
            var dishTree = new DishTree();

            var expected = new Dish
            {
                Attribute = "doce",
                Identifier = "Sorvete",
                Left = null,
                Right = null
            };

            dishTree.AddNodeToRight(dishTree.Root, expected);

            Assert.IsTrue(dishTree.NodeHasRight(dishTree.Root));
        }
    }
}
