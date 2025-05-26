using System;

namespace DelegateAsParameterExample
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

        // Метод, принимающий делегат в качестве параметра
        public static void ExecuteDelegate(MessageDelegate messageDelegate)
        {
            try
            {
                Console.WriteLine(messageDelegate());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        public static void Main(string[] args)
        {
            MessageDelegate messageDelegateOne = MessageOne;
            MessageDelegate messageDelegateTwo = MessageTwo;
            MessageDelegate messageDelegateThree = MessageThree;

            ExecuteDelegate(messageDelegateOne);
            ExecuteDelegate(messageDelegateTwo);
            ExecuteDelegate(messageDelegateThree);
        }
    }
}

