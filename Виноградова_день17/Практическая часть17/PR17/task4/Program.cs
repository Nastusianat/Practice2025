using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\file1.txt.txt"; 
        string outputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\file2.txt.txt";

        try
        {
            var lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace('0', '2') 
                                   .Replace('1', '0') 
                                   .Replace('2', '1'); 
            }

            File.WriteAllLines(outputFilePath, lines);
            Console.WriteLine($"Строки переписаны в '{outputFilePath}' с заменой символов.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}