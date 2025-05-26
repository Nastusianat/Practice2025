using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество дней: ");
        int days = int.Parse(Console.ReadLine()); 
        int weeks = days / 7; 

        Console.WriteLine($"Количество полных недель: {weeks}");
    }
}
