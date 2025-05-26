using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\Практическая часть17\f.txt.txt";
        string outputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\Практическая часть17\g.txt.txt";

        try
        {
            var numbers = File.ReadAllLines(inputFilePath)
                              .Select(int.Parse) //преобразовываем в строки
                              .Where(n => n > 0); //фильтруем числа

            var divisibleByThree = numbers.Where(n => n % 3 == 0); //фильтрация чисел делящихся на 3

            File.WriteAllLines(outputFilePath, divisibleByThree.Select(n => n.ToString()));

            Console.WriteLine("Числа, делящиеся на 3, успешно записаны в файл g.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}


