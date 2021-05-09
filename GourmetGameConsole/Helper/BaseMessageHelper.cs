using System;

namespace GourmetGameConsole.Helper
{
    public abstract class BaseMessageHelper
    {
        protected void YesOrNo()
        {
            Console.WriteLine("[1] SIM");
            Console.WriteLine("[2] NÃO\n");
        }

        protected string GetAnswer()
        {
            string answer;

            Console.Write("Resposta: ");

            do
            {
                answer = Console.ReadLine();
            } while (string.IsNullOrEmpty(answer));

            return answer;
        }

        public void Guessed()
        {
            Console.Clear();
            Console.WriteLine("Acertei de novo!");
            Console.ReadLine();
        }


        public abstract void InitialMessage();
        public abstract bool AskQuestion(string attribute);
        public abstract string NewEntry();
        public abstract string NewAttribute(string currentEntry, string previousEntry);
    }
}
