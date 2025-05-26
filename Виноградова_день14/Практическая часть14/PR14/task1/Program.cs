using System;

namespace DelegateExample
{
    public class Program
    {
        public delegate string MessageDelegate();

        public static string MessageOne()
        {
            return "Это первое сообщение.";
        }

        public static string MessageTwo()
        {
            return "Это второе сообщение.";
        }

        public static string MessageThree()
        {
            return "Это третье сообщение.";
        }

        public static void Main(string[] args)
        {
            MessageDelegate messageDelegate = MessageOne;
            messageDelegate += MessageTwo;
            messageDelegate += MessageThree;

            foreach (MessageDelegate method in messageDelegate.GetInvocationList())
            {
                Console.WriteLine(method());
            }
        }
    }
}
