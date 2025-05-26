using System;
using TriangleLibrary;
using RectangleLibrary;

class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        if (triangle.IsValid())
        {
            Console.WriteLine($"Периметр треугольника: {triangle.GetPerimeter()}");
            Console.WriteLine($"Площадь треугольника: {triangle.GetArea()}");
            Console.WriteLine($"Тип треугольника: {triangle.GetTriangleType()}");
        }
        else
        {
            Console.WriteLine("Треугольник не существует.");
        }

        Rectangle rectangle = new Rectangle(5, 10);
        Console.WriteLine($"Периметр прямоугольника: {rectangle.GetPerimeter()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.GetArea()}");
    }
}
