using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x == -2 || x == 1)
                throw new DivideByZeroException("Ошибка: Деление на ноль!");

            double y1 = (5 * x - 7) / (4 * x + 8);
            double y2 = Math.Tan(x) + Math.Cos(x) / (x - 1);

            Console.WriteLine($"Результат первого выражения: {y1:F4}");
            Console.WriteLine($"Результат второго выражения: {y2:F4}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Некорректный формат ввода. Введите число.");
        }
    }
}
