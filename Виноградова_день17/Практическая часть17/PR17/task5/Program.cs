using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\numbers.txt";
        double[] numbers = { 1.5, -2.3, 3.0, 4.7, -1.2, 5.9 }; 
        double threshold = 2.0; 

        File.WriteAllLines(filePath, numbers.Select(n => n.ToString()));

        Console.WriteLine("Числа, меньшие заданного числа:");
        var readNumbers = File.ReadAllLines(filePath).Select(double.Parse);
        foreach (var number in readNumbers.Where(n => n < threshold))
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nПоложительные числа:");
        foreach (var number in readNumbers.Where(n => n > 0))
        {
            Console.WriteLine(number);
        }

   
        double evenPositionAverage = readNumbers //находим среднее арифметическое
            .Where((n, index) => index % 2 == 0) 
            .DefaultIfEmpty(0) 
            .Average();

        Console.WriteLine($"\nСреднее арифметическое на четных позициях: {evenPositionAverage}");
    }
}
