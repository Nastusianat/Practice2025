using System;
using System.Collections.Generic;

public abstract class Furniture
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Furniture(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}

public class Cabinet : Furniture
{
    public double Height { get; set; } 

    public Cabinet(string name, double price, double height) : base(name, price)
    {
        Height = height;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Шкаф: {Name}, Цена: {Price} руб., Высота: {Height} см");
    }
}

public class Sofa : Furniture
{
    public int Seats { get; set; } 

    public Sofa(string name, double price, int seats) : base(name, price)
    {
        Seats = seats;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Диван: {Name}, Цена: {Price} руб., Количество мест: {Seats}");
    }
}

class Program
{
    static void Main()
    {
        List<Furniture> furnitureList = new List<Furniture>
        {
            new Cabinet("Шкаф1", 5000, 200),
            new Cabinet("Шкаф2", 7000, 220),
            new Sofa("Диван1", 10000, 3),
            new Sofa("Диван2", 12000, 4),
            new Sofa("Диван3", 9000, 2)
        };

        double totalCabinetPrice = 0;
        int cabinetCount = 0;
        double totalSofaPrice = 0;
        int sofaCount = 0;

        foreach (var furniture in furnitureList)
        {
            furniture.DisplayInfo();

            if (furniture is Cabinet cabinet)
            {
                totalCabinetPrice += cabinet.Price;
                cabinetCount++;
            }
            else if (furniture is Sofa sofa)
            {
                totalSofaPrice += sofa.Price;
                sofaCount++;
            }
        }

        double averageCabinetPrice = cabinetCount > 0 ? totalCabinetPrice / cabinetCount : 0;
        double averageSofaPrice = sofaCount > 0 ? totalSofaPrice / sofaCount : 0;

        Console.WriteLine($"\nСредняя стоимость шкафов: {averageCabinetPrice} руб.");
        Console.WriteLine($"Средняя стоимость диванов: {averageSofaPrice:F0} руб.");
    }
}
