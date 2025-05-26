using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите угол α (в градусах): ");
        double alphaDegrees = Convert.ToDouble(Console.ReadLine());

        double alpha = alphaDegrees * Math.PI / 180;

        double z1 = (Math.Cos(alpha) + Math.Sin(alpha)) / (Math.Cos(alpha) - Math.Sin(alpha));

        double z2 = Math.Tan(2 * alpha) + 1 / Math.Cos(2 * alpha);

        Console.WriteLine($"Результат по первой формуле: z1 = {z1:F4}");
        Console.WriteLine($"Результат по второй формуле: z2 = {z2:F4}");

        if (Math.Abs(z1 - z2) < 1e-4)
        {
            Console.WriteLine("Результаты двух формул совпадают (с точностью до 0.0001).");
        }
        else
        {
            Console.WriteLine("Результаты двух формул различаются.");
        }
    }
}
