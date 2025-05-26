using System;
using System.IO;
using System.Linq;

/// <summary>
/// Класс Program выполняет обработку чисел из файла: фильтрация положительных чисел и запись в новый файл только тех, которые делятся на 3.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Читает данные из входного файла, фильтрует их и записывает в выходной файл числа, делящиеся на 3.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к входному файлу, содержащему список чисел.
        /// </summary>
        string inputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\Практическая часть17\f.txt.txt";

        /// <summary>
        /// Путь к выходному файлу, в который записываются отфильтрованные числа.
        /// </summary>
        string outputFilePath = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\Практическая часть17\g.txt.txt";

        try
        {
            /// <summary>
            /// Чтение чисел из файла, отбор только положительных значений.
            /// </summary>
            var numbers = File.ReadAllLines(inputFilePath)
                              .Select(int.Parse)
                              .Where(n => n > 0);

            /// <summary>
            /// Фильтрация чисел, делящихся на 3.
            /// </summary>
            var divisibleByThree = numbers.Where(n => n % 3 == 0);

            /// <summary>
            /// Запись отфильтрованных чисел в выходной файл.
            /// </summary>
            File.WriteAllLines(outputFilePath, divisibleByThree.Select(n => n.ToString()));

            Console.WriteLine("Числа, делящиеся на 3, успешно записаны в файл g.");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка ошибок при работе с файлами и вывод сообщения об ошибке.
            /// </summary>
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
