using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string reversedText = string.Join(" ", words.Reverse());

        Console.WriteLine("Результат:");
        Console.WriteLine(reversedText);
    }
}
