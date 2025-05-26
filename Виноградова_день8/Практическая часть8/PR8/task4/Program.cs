using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine(); 

        string pattern = @"\b[аеёиоуыэюяАЕЁИОУЫЭЮЯ]\w*\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Слова, начинающиеся с гласной буквы:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}

