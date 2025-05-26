using System;

class Program
{
    static double CalculateFunction(double x)
    {
        if (x <= -4 || x >= 1)
            throw new ArgumentOutOfRangeException("Ошибка: x выходит за допустимые пределы (-4, 1)!");

        if (x == 2)
            throw new DivideByZeroException("Ошибка: Деление на ноль!");

        return (3 * x) / (x - 2);
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = CalculateFunction(x);
            Console.WriteLine($"Результат функции: {result}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
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
