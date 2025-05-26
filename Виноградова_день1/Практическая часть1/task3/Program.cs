using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double y = x * Math.Exp(Math.Pow(x, 2)) -
                   (Math.Sin(Math.Sqrt(x)) + Math.Pow(Math.Cos(Math.Log(x)), 2)) /
                   Math.Sqrt(Math.Abs(1 - Math.PI * x));

        Console.WriteLine($"Результат: y = {y:F3}");
    }
}
