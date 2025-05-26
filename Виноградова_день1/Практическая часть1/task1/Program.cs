using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое вещественное число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе вещественное число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 != 0)
        {
            double result = num1 / num2;
            Console.WriteLine($"Результат деления: {result:F3}");
        }
        else
        {
            Console.WriteLine("Ошибка: деление на ноль невозможно.");
        }

        Console.WriteLine("Для продолжения нажмите любую клавишу...");
        Console.ReadKey();
    }
}
