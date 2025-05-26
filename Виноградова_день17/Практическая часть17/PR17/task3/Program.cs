using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\input.txt";
        string outputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\output.txt";
        string outFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\out.txt";

        File.WriteAllLines(inputFilePath, new string[]
        {
            "Первая строка",
            "Вторая",
            "Третья строка - больше",
            "Четвертая строка",
            "Пятая"
        });

        Console.WriteLine("Содержимое файла:");
        var lines = File.ReadAllLines(inputFilePath);
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        int lineCount = lines.Length;
        Console.WriteLine($"\nКоличество строк: {lineCount}");

        Console.WriteLine("Количество символов в каждой строке:");
        foreach (var line in lines)
        {
            Console.WriteLine($"{line}: {line.Length}");
        }

        File.WriteAllLines(outputFilePath, lines.Take(lineCount - 1)); //в выходной файл записываем строки без последней
        Console.WriteLine($"\nФайл без последней строки записан в '{outputFilePath}'.");

        int s1 = 1; 
        int s2 = 3; 
        Console.WriteLine("\nСтроки с s1 по s2:");
        for (int i = s1 - 1; i <= s2 - 1 && i < lineCount; i++)
        {
            Console.WriteLine(lines[i]);
        }

        int maxLength = lines.Max(line => line.Length);
        string longestLine = lines.First(line => line.Length == maxLength);
        Console.WriteLine($"\nСамая длинная строка: '{longestLine}' (длина: {maxLength})");

        char startChar = 'П'; 
        Console.WriteLine($"\nСтроки, начинающиеся с '{startChar}':");
        foreach (var line in lines.Where(line => line.StartsWith(startChar)))
        {
            Console.WriteLine(line);
        }

        File.WriteAllLines(outFilePath, lines.Reverse());
        Console.WriteLine($"\nСтроки переписаны в '{outFilePath}' в обратном порядке.");
    }
}
