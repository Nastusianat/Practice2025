using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;

            int reversedNumber = secondDigit * 10 + firstDigit;

            Console.WriteLine($"Новое число: {reversedNumber}");
        }
        else
        {
            Console.WriteLine("Ошибка: введенное число не является двузначным.");
        }
    }
}
