using System;

class Program
{
    static void Main()
    {
        int M = 15;
        double A = Math.PI / 4;
        double B = Math.PI / 2;
        double H = (B - A) / M;

        Console.WriteLine("x\tctg(x)");
        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;
            double y = 1.0 / Math.Tan(x); // Вычисление ctg(x)
            Console.WriteLine($"{x:F4}\t{y:F4}");
        }
    }
}
