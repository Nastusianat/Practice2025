using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        var digitCounts = input.Where(char.IsDigit)
                               .GroupBy(d => d)
                               .ToDictionary(g => g.Key, g => g.Count());

        if (digitCounts.Count > 0)
        {
            char mostFrequentDigit = input.First(c => digitCounts.ContainsKey(c) &&
                                                      digitCounts[c] == digitCounts.Values.Max());

            Console.WriteLine($"Чаще всего встречалась цифра: {mostFrequentDigit}");
        }
        else
        {
            Console.WriteLine("В строке нет цифр.");
        }
    }
}
