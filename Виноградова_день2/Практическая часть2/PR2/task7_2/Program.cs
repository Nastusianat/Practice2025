using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите стоимость одной штуки товара: ");
        double price = double.Parse(Console.ReadLine());

        int quantity = 10;
        Console.WriteLine("Таблица стоимости товара:");
        do
        {
            Console.WriteLine($"{quantity} штук = {quantity * price:F2} руб.");
            quantity += 10;
        } while (quantity <= 200);
    }
}
