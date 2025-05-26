using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите стоимость одной штуки товара: ");
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine("Таблица стоимости товара:");
        for (int quantity = 10; quantity <= 200; quantity += 10)
        {
            Console.WriteLine($"{quantity} штук = {quantity * price:F2} руб.");
        }
    }
}
