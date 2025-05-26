using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        bool isOrdered = IsDigitsOrdered(number);
        Console.WriteLine($"Цифры числа {number} упорядочены по возрастанию справа налево: {isOrdered}");
    }

    static bool IsDigitsOrdered(int num)
    {
        int previousDigit = num % 10; // Последняя цифра
        num /= 10;

        while (num > 0)
        {
            int currentDigit = num % 10; // Текущая цифра
            if (currentDigit > previousDigit) // Проверка порядка
            {
                return false;
            }
            previousDigit = currentDigit;
            num /= 10;
        }

        return true;
    }
}
