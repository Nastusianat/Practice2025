using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 10 == 7)
        {
            Console.WriteLine("Число оканчивается на 7.");
        }
        else
        {
            Console.WriteLine("Число не оканчивается на 7.");
        }
    }
}
