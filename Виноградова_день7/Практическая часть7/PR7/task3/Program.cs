using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length < 3)
        {
            Console.WriteLine("Слишком мало слов в предложении для выполнения всех операций.");
            return;
        }

        (words[0], words[words.Length - 1]) = (words[words.Length - 1], words[0]);

        string mergedWords = words[1] + words[2];

        string reversedThirdWord = new string(words[2].Reverse().ToArray());

        string firstWordTrimmed = words[0].Length > 2 ? words[0].Substring(2) : words[0];

        Console.WriteLine($"Перемена местами первого и последнего слов: {string.Join(" ", words)}");
        Console.WriteLine($"Склеенные второе и третье слова: {mergedWords}");
        Console.WriteLine($"Третье слово в обратном порядке: {reversedThirdWord}");
        Console.WriteLine($"Первое слово без первых двух букв: {firstWordTrimmed}");
    }
}
