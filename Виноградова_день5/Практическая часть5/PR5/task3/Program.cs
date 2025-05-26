using System;

class Program
{
    static void RectPS(double x1, double y1, double x2, double y2, out double P, out double S)
    {
        if (x1 == x2 || y1 == y2)
            throw new ArgumentException("Ошибка: Координаты вершин должны задавать правильный прямоугольник!");

        double width = Math.Abs(x2 - x1);
        double height = Math.Abs(y2 - y1);

        P = 2 * (width + height);
        S = width * height;
    }

    static void Main()
    {
        try
        {
            double[,] rectangles = {
                { 1, 1, 4, 5 },
                { -2, -3, 3, 2 },
                { 0, 0, 6, 7 }
            };

            for (int i = 0; i < rectangles.GetLength(0); i++)
            {
                double P, S;
                RectPS(rectangles[i, 0], rectangles[i, 1], rectangles[i, 2], rectangles[i, 3], out P, out S);
                Console.WriteLine($"Прямоугольник {i + 1}: Периметр = {P}, Площадь = {S}");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Некорректный формат ввода. Введите числа.");
        }
    }
}
