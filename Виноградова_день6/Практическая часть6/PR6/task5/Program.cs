using System;

class Program
{
    static int RecursiveFunction(int n)
    {
        if (n <= 2)
            return 1; 

        return (n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine("Ошибка: n должно быть >= 2.");
        }
        else
        {
            int result = RecursiveFunction(n);
            Console.WriteLine($"f({n}) = {result}");
        }
    }
}

