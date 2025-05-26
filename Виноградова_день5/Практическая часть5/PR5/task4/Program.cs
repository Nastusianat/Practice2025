using System;
class Program
{
    static void Main()
    {
        byte x = 200; byte y = 200;
        try
        {
            byte result = unchecked((byte)(x + y));
            Console.WriteLine("1: {0}", result);
            result = checked((byte)(x + y));
            Console.WriteLine("2:", result);
        }
        catch (OverflowException)
        {
            Console.WriteLine("возникло переполнение");
        }
    }
}
//исключение OverflowException возникнет сразу при первой попытке сложить х+у и строка 7 не выполнится