using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int A = -6, B = 4;

        Parallel.For(A, B + 1, x =>
        {
            if (Math.Sin(x) != 0) 
            {
                double result = Math.Cos(x) / Math.Sin(x);
                Console.WriteLine($"ctg({x}) = {result:F3}");
            }
            else
            {
                Console.WriteLine($"ctg({x}) не определен (деление на 0)");
            }
        });
    }
}
