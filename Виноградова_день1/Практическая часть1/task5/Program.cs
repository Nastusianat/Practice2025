using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите цену тетради (руб.): ");
        double notebookPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество тетрадей: ");
        int notebookCount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите цену карандаша (руб.): ");
        double pencilPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество карандашей: ");
        int pencilCount = Convert.ToInt32(Console.ReadLine());

        double totalCost = notebookPrice * notebookCount + pencilPrice * pencilCount;

        Console.WriteLine($"Стоимость покупки: {totalCost:F2} руб.");
    }
}
