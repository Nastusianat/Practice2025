using System;

class Program
{
    static double Sum(double a, double b)
    {
        return a + b;
    }

    static double Sum(double a, double b, double c)
    {
        return a + b + c;
    }

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
