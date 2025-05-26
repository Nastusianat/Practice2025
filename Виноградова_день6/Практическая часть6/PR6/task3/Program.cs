using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер матрицы (N < 10):");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите границы диапазона [a, b]:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rand.Next(a, b + 1);
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix, n);

        Console.WriteLine("Введите число D:");
        int d = int.Parse(Console.ReadLine());

        int countLessD = 0;
        foreach (int num in matrix)
        {
            if (num < d) countLessD++;
        }
        Console.WriteLine($"Количество чисел, меньших {d}: {countLessD}");

        Console.WriteLine("Среднее арифметическое каждого столбца:");
        for (int j = 0; j < n; j++)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, j];
            }
            Console.WriteLine($"Столбец {j + 1}: {sum / n:F2}");
        }
    }

    static void PrintMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{matrix[i, j],5}");
            }
            Console.WriteLine();
        }
    }
}
