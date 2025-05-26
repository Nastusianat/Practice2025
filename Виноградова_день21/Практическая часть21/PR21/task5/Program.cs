using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = { 11, 12, 15, 68 };

        Parallel.ForEach(numbers, (n, state) =>
        {
            long sum = 0;
            for (int i = 0; i <= n; i++) sum += i;

            long product = 1;
            if (n > 0) 
            {
                for (int i = 1; i <= n; i++) product *= i;
            }

            Console.WriteLine($"N = {n}, Sum = {sum}, Product = {product}");

            if (product > 100_000_000)
            {
                Console.WriteLine($"Произведение превысило 100 000 000 для N = {n}. Прерываем выполнение.");
                state.Stop(); 
            }
        });
    }
}