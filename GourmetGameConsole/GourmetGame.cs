using GourmetGameConsole.DataStructure;
using GourmetGameConsole.Helper;

namespace GourmetGameConsole
{
    public class GourmetGame
    {
        private readonly DishTree _tree;
        private readonly MessageHelper _messageHelper;

        public GourmetGame()
        {
            _messageHelper = new MessageHelper();
            _tree = new DishTree();
        }

        public void Run()
        {
            while (true)
            {
                StartGame();
                TraverseTree(_tree.Root);
                _tree.LastPositiveAnswer = null;
            }
        }

        private void StartGame()
        {
            _messageHelper.InitialMessage();
        }

        private void TraverseTree(Dish node)
        {
            var characteristicAnswer = _messageHelper.AskQuestion(node.Attribute);

            if (characteristicAnswer)
            {
                if (_tree.NodeHasLeft(node))
                {
                    _tree.LastPositiveAnswer = node;
                    TraverseTree(node.Left);
                }
                else
                {
                    var dishAnswer = _messageHelper.AskQuestion(node.Identifier);

                    if (dishAnswer)
                    {
                        _messageHelper.Guessed();
                    }
                    else
                    {
                        var newNode = NewEntry(node.Identifier);
                        _tree.AddNodeToLeft(node, newNode);
                    }
                }
            }
            else
            {
                if (_tree.NodeHasRight(node))
                {
                    TraverseTree(node.Right);
                }
                else
                {
                    var dish = node.Right?.Identifier ?? _tree.LastPositiveAnswer?.Identifier ?? _tree.Default;

                    var dishAnswer = _messageHelper.AskQuestion(dish);

                    if (dishAnswer)
                    {
                        _messageHelper.Guessed();
                    }
                    else
                    {
                        var newNode = NewEntry(node.Identifier);
                        _tree.AddNodeToRight(node, newNode);
                    }
                }
            }
        }

        private Dish NewEntry(string previousDish)
        {
            var newDish = _messageHelper.NewEntry();
            var newCharacteristic = _messageHelper.NewAttribute(newDish, previousDish);
            
            return _tree.NewNode(newDish, newCharacteristic);
        }
    }
}
