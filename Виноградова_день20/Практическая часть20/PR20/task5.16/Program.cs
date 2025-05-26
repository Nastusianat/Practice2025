using System;
using System.IO;
using System.Linq;

/// <summary>
/// Класс Program выполняет операции с числовыми данными, включая запись в файл, фильтрацию и вычисление средних значений.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Записывает массив чисел в файл, выполняет их обработку и выводит результаты.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к файлу, содержащему числовые данные.
        /// </summary>
        string filePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\numbers.txt";

        /// <summary>
        /// Исходный массив чисел.
        /// </summary>
        double[] numbers = { 1.5, -2.3, 3.0, 4.7, -1.2, 5.9 };

        /// <summary>
        /// Пороговое значение для фильтрации.
        /// </summary>
        double threshold = 2.0;

        // Запись чисел в файл
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

        /// <summary>
        /// Вычисляет среднее арифметическое чисел, находящихся на четных позициях в массиве.
        /// </summary>
        double evenPositionAverage = readNumbers
            .Where((n, index) => index % 2 == 0)
            .DefaultIfEmpty(0)
            .Average();

        Console.WriteLine($"\nСреднее арифметическое на четных позициях: {evenPositionAverage}");
    }
}
