using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите h (шаг): ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("\nТаблица значений функции:");
        Console.WriteLine("╔═════════╦═════════╗");
        Console.WriteLine("║    x    ║  f(x)  ║");
        Console.WriteLine("╠═════════╬═════════╣");

        for (double x = a; x <= b; x += h)
        {
            double fx = CalculateFunction(x, a, b);
            Console.WriteLine($"║ {x,7:F2} ║ {fx,7:F2} ║");
        }

        Console.WriteLine("╚═════════╩═════════╝");
    }

    static double CalculateFunction(double x, double a, double b)
    {
        if (3 * x > 10)
            return a + b * x;
        else if (3 * x > -3)
            return a - b * x;
        else
            return a * b;
    }
}
