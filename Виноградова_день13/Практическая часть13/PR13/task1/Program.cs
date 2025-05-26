using System;

class Program
{
    public delegate double CalcFigure(double radius);

    public static double Get_Length(double radius)
    {
        return 2 * Math.PI * radius;
    }

    public static double Get_Area(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public static double Get_Volume(double radius)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }

    static void Main()
    {
        CalcFigure CF;

        double radius = 5.0; 

        CF = Get_Length;
        Console.WriteLine($"Длина окружности с радиусом {radius}: {CF(radius):F2}");

        CF = Get_Area;
        Console.WriteLine($"Площадь круга с радиусом {radius}: {CF(radius):F2}");

        CF = Get_Volume;
        Console.WriteLine($"Объем шара с радиусом {radius}: {CF(radius):F2}");
    }
}

