using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { -10, 6, 51, 11, 23, -5, -1, 77 };

        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(" ", array));

        Array.Sort(array);
        Console.WriteLine("Отсортированный массив:");
        Console.WriteLine(string.Join(" ", array));

        Console.WriteLine("Введите число k для бинарного поиска:");
        int k = int.Parse(Console.ReadLine());

        int index = Array.BinarySearch(array, k);
        if (index >= 0)
            Console.WriteLine($"Число {k} найдено в отсортированном массиве на позиции {index}.");
        else
            Console.WriteLine($"Число {k} не найдено в отсортированном массиве.");

        int sumPositive = array.Where(x => x > 0).Sum();
        int countNegative = array.Count(x => x < 0);
        int countZero = array.Count(x => x == 0);

        Console.WriteLine($"Сумма положительных элементов: {sumPositive}");
        Console.WriteLine($"Количество отрицательных элементов: {countNegative}");
        Console.WriteLine($"Количество нулевых элементов: {countZero}");
    }
}
