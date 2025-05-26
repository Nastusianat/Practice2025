using System;

/// <summary>
/// Класс Program демонстрирует использование делегатов для вычисления параметров геометрических фигур.
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для вычисления параметров фигуры на основе ее радиуса.
    /// </summary>
    /// <param name="radius">Радиус фигуры.</param>
    /// <returns>Вычисленное значение (длина, площадь или объем).</returns>
    public delegate double CalcFigure(double radius);

    /// <summary>
    /// Вычисляет длину окружности по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус окружности.</param>
    /// <returns>Длина окружности.</returns>
    public static double Get_Length(double radius)
    {
        return 2 * Math.PI * radius;
    }

    /// <summary>
    /// Вычисляет площадь круга по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <returns>Площадь круга.</returns>
    public static double Get_Area(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    /// <summary>
    /// Вычисляет объем шара по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус шара.</param>
    /// <returns>Объем шара.</returns>
    public static double Get_Volume(double radius)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }

    /// <summary>
    /// Точка входа в приложение. Демонстрирует работу с делегатом CalcFigure.
    /// </summary>
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
