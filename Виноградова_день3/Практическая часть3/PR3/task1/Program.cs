using System;

class A
{
    public int a { get; set; }
    public int b { get; set; }

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public double Average()
    {
        return (a + b) / 2.0;
    }

    public double CalculateExpression()
    {
        return Math.Pow(b, 3) + Math.Sqrt(a);
    }
}

class Program
{
    static void Main()
    {
        A obj = new A(4, 2);

        Console.WriteLine($"Среднее арифметическое: {obj.Average()}");
        Console.WriteLine($"Результат выражения b^3 + sqrt(a): {obj.CalculateExpression()}");
    }
}
