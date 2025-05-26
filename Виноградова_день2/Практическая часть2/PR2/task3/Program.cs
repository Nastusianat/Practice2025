using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите цену за 1 кг конфет: ");
        double A = double.Parse(Console.ReadLine());

        if (A < 1 || A > 100)
        {
            Console.WriteLine("Цена должна быть в диапазоне от 1 до 100.");
            return;
        }

        Console.WriteLine("Стоимость конфет для различных весов:");

        for (double weight = 0.1; weight <= 1.0; weight += 0.1)
        {
            Console.WriteLine($"{weight:F1} кг: {A * weight:F4} руб.");
        }
    }
}
