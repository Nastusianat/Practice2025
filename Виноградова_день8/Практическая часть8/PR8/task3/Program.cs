using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine(); 

        string pattern = @"\d";

        if (Regex.IsMatch(text, pattern))
        {
            Console.WriteLine("Текст содержит цифры.");
        }
        else
        {
            Console.WriteLine("Текст не содержит цифр.");
        }
    }
}
