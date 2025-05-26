using System;
using System.IO;
using System.Linq;

/// <summary>
/// Класс Program выполняет различные операции с текстовыми файлами:
/// - запись строк в файл,
/// - чтение и анализ строк,
/// - обработку строк на основе их длины и начального символа,
/// - перезапись строк в обратном порядке.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Выполняет операции чтения, анализа и записи текстовых данных.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к входному файлу, содержащему исходные строки.
        /// </summary>
        string inputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\input.txt";

        /// <summary>
        /// Путь к выходному файлу, содержащему строки без последней строки.
        /// </summary>
        string outputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\output.txt";

        /// <summary>
        /// Путь к файлу, содержащему строки в обратном порядке.
        /// </summary>
        string outFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\out.txt";

        // Запись строк в входной файл
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

        // Подсчет количества строк
        int lineCount = lines.Length;
        Console.WriteLine($"\nКоличество строк: {lineCount}");

        // Подсчет количества символов в каждой строке
        Console.WriteLine("Количество символов в каждой строке:");
        foreach (var line in lines)
        {
            Console.WriteLine($"{line}: {line.Length}");
        }

        // Запись строк без последней строки в выходной файл
        File.WriteAllLines(outputFilePath, lines.Take(lineCount - 1));
        Console.WriteLine($"\nФайл без последней строки записан в '{outputFilePath}'.");

        // Вывод строк с s1 по s2
        int s1 = 1;
        int s2 = 3;
        Console.WriteLine("\nСтроки с s1 по s2:");
        for (int i = s1 - 1; i <= s2 - 1 && i < lineCount; i++)
        {
            Console.WriteLine(lines[i]);
        }

        // Определение самой длинной строки
        int maxLength = lines.Max(line => line.Length);
        string longestLine = lines.First(line => line.Length == maxLength);
        Console.WriteLine($"\nСамая длинная строка: '{longestLine}' (длина: {maxLength})");

        // Фильтрация строк, начинающихся с заданного символа
        char startChar = 'П';
        Console.WriteLine($"\nСтроки, начинающиеся с '{startChar}':");
        foreach (var line in lines.Where(line => line.StartsWith(startChar)))
        {
            Console.WriteLine(line);
        }

        // Запись строк в обратном порядке в файл
        File.WriteAllLines(outFilePath, lines.Reverse());
        Console.WriteLine($"\nСтроки переписаны в '{outFilePath}' в обратном порядке.");
    }
}
