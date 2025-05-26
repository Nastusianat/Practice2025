using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void ProcessFile(string filePath)
    {
        Queue<char> nonDigits = new Queue<char>();
        Queue<char> digits = new Queue<char>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                char c = (char)reader.Read();
                if (char.IsDigit(c))
                {
                    digits.Enqueue(c);
                }
                else
                {
                    nonDigits.Enqueue(c);
                }
            }
        }

        Console.WriteLine("Символы, отличные от цифр:");
        while (nonDigits.Count > 0)
        {
            Console.Write(nonDigits.Dequeue());
        }

        Console.WriteLine("\nЦифры:");
        while (digits.Count > 0)
        {
            Console.Write(digits.Dequeue());
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите путь к текстовому файлу:");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            ProcessFile(filePath);
        }
        else
        {
            Console.WriteLine("Файл не найден.");
        }
    }
}

