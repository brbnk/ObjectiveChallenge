using System;

namespace GourmetGameConsole.Helper
{
    public class MessageHelper : BaseMessageHelper
    {
        public override void InitialMessage()
        {
            Console.Clear();
            Console.WriteLine("Pense em um prato que você goste");
            Console.Write("PRESS ENTER [OK]");
            Console.ReadLine();
        }

        public override bool AskQuestion(string attribute)
        {
            string answer;

            do
            {
                Console.Clear();
                Console.WriteLine($"O seu prato é {attribute}?");
                YesOrNo();
                answer = GetAnswer();
            } while (answer != "1" && answer != "2");

            return answer == "1";
        }

        public override string NewEntry()
        {
            Console.Clear();
            Console.WriteLine("Em qual prato você pensou?");
            return GetAnswer();
        }

        public override string NewAttribute(string currentEntry, string previousEntry)
        {
            Console.Clear();
            Console.WriteLine($"{currentEntry} é ______________, mas {previousEntry} não.");
            return GetAnswer();
        }
    }
}
