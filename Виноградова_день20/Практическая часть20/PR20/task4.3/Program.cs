using System;

/// <summary>
/// Класс Program содержит методы для вычисления суммы чисел.
/// </summary>
class Program
{
    /// <summary>
    /// Вычисляет сумму двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Сумма двух чисел.</returns>
    static double Sum(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Вычисляет сумму трех чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <param name="c">Третье число.</param>
    /// <returns>Сумма трех чисел.</returns>
    static double Sum(double a, double b, double c)
    {
        return a + b + c;
    }

    /// <summary>
    /// Точка входа в приложение. Запрашивает у пользователя числа и вычисляет их сумму.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите a1: ");
        double a1 = double.Parse(Console.ReadLine());

        Console.Write("Введите b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите a2: ");
        double a2 = double.Parse(Console.ReadLine());

        Console.Write("Введите b2: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.Write("Введите c2: ");
        double c2 = double.Parse(Console.ReadLine());

        double result = Sum(a1, b1) + Sum(a2, b2, c2);

        Console.WriteLine($"Результат Sum(a1, b1) + Sum(a2, b2, c2) = {result}");
    }
}
