using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 100 && number <= 999)
        {
            int lastDigit = number % 10;

            int remainingNumber = number / 10;

            int result = lastDigit * 100 + remainingNumber;

            Console.WriteLine($"Полученное число: {result}");
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное трехзначное число.");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
