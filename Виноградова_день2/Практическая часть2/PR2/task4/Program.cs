using System;

class Program
{
    static double CalculateFunction(double x)
    {
        if (x > 1)
        {
            return Math.Log(2 * x) + Math.Sqrt(1 + x * x);
        }
        else
        {
            return 2 * Math.Cos(x) + 3 * x * x;
        }
    }

    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        double y = CalculateFunction(x);
        Console.WriteLine($"Значение функции: y = {y:F4}");
    }
}
