using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string userInput = Console.ReadLine(); 

        string pattern = @"\b\w+-\w+\b";

        MatchCollection matches = Regex.Matches(userInput, pattern);

        Console.WriteLine("Слова с дефисом:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
