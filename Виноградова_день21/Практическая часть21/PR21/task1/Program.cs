using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number = 123; 

        Task<int> task1 = new Task<int>(() => TransformNumber(number));
        task1.Start();
        Console.WriteLine($"Вариант 1: {task1.Result}");

        Task<int> task2 = Task.Run(() => TransformNumber(number));
        Console.WriteLine($"Вариант 2: {task2.Result}");

        Task<int> task3 = Task.Factory.StartNew(() => TransformNumber(number));
        Console.WriteLine($"Вариант 3: {task3.Result}");
    }

    static int TransformNumber(int num)
    {
        int lastDigit = num % 10; 
        int remainingDigits = num / 10; 

        return int.Parse($"{lastDigit}{remainingDigits}"); 
    }
}
