using System;

class Program
{
    static void genException()
    {
        Console.WriteLine("a=");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        double b = double.Parse(Console.ReadLine());
        int f = 1;

        try 
        {
            for (double i = a; i <= b; ++i)
            {
                try 
                {
                    f = checked((int)(f * i));

                    if (Math.Abs(f - 1) < 0.000001)
                        throw new DivideByZeroException("Ошибка: f - 1 слишком близко к 0!");

                    Console.WriteLine("y({0})={1:f6}", i, 100 / (f - 1));
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("y({0})=Деление на 0: {1}", i, ex.Message);
                }
            }
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("ERROR");
            throw; // Повторная генерация исключения
        }
    }

    static void Main()
    {
        try
        {
            genException();
        }
        catch
        {
            Console.WriteLine("НЕИСПРАВИМАЯ ОШИБКА!!!");
        }
    }
}
