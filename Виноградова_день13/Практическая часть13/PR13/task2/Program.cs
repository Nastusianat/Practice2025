using System;

public class Program
{
    public static void Main()
    {
        Func<double, double, double> Add = (a, b) => a + b;
        Func<double, double, double> Sub = (a, b) => a - b;
        Func<double, double, double> Mul = (a, b) => a * b;
        Func<double, double, double> Div = (a, b) =>
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Делить на нуль нельзя!");
            }
            return a / b;
        };

        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите операцию: +, -, *, /");
        string operation = Console.ReadLine();

        try
        {
            double result = operation switch
            {
                "+" => Add(num1, num2),
                "-" => Sub(num1, num2),
                "*" => Mul(num1, num2),
                "/" => Div(num1, num2),
                _ => throw new InvalidOperationException("Неверная операция")
            };

            Console.WriteLine($"Результат: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Нужно ввести число!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}

