using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите вещественное число A (-5 <= A <= 5): ");
        double A = double.Parse(Console.ReadLine());

        Console.Write("Введите целое число N (1 <= N <= 10): ");
        int N = int.Parse(Console.ReadLine());

        if (A < -5 || A > 5 || N < 1 || N > 10)
        {
            Console.WriteLine("Ошибка: Числа A и N должны соответствовать заданному диапазону.");
            return;
        }

        double sum = 1;
        double currentTerm = 1;

        for (int i = 1; i <= N; i++)
        {
            currentTerm *= A;
            sum += currentTerm;
        }

        Console.WriteLine($"Сумма последовательности: {sum:F4}");
    }
}
