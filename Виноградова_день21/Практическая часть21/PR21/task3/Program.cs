using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number = 42; 

        Task<int> task1 = Task.Run(() => SwapDigits(number));

        Task task2 = task1.ContinueWith(t =>
        {
            Console.WriteLine($"Переставленное число: {t.Result}");
        });

        task2.Wait();
    }

    static int SwapDigits(int num)
    {
        int firstDigit = num / 10; 
        int secondDigit = num % 10; 
        return int.Parse($"{secondDigit}{firstDigit}"); 
    }
}
