using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            bool isThreeDigitOdd = Math.Abs(number) >= 100 && Math.Abs(number) <= 999 && number % 2 != 0;
            Console.WriteLine($"Число {number} является нечетным трехзначным: {isThreeDigitOdd}");
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное целое число.");
        }
    }
}

