using System;

interface Ix
{
    string IxF0(string parameter);
    string IxF1(string parameter);
}

interface Iy
{
    string F0(string parameter);
    string F1(string parameter);
}

interface Iz
{
    string F0(string parameter);
    string F1(string parameter);
}

class TestClass : Ix, Iy, Iz
{
    private string w;

    public TestClass(string w)
    {
        this.w = w;
    }

    public string IxF0(string parameter)
    {
        return parameter.Length > 2 ? parameter.Substring(0, parameter.Length - 2) : parameter;
    }

    public string IxF1(string parameter)
    {
        return parameter.Length > 2 ? parameter.Substring(0, parameter.Length - 2) : parameter;
    }

    public string F0(string parameter)
    {
        return parameter.Length > 2 ? parameter.Substring(2) : parameter;
    }

    public string F1(string parameter)
    {
        return parameter.Length > 2 ? parameter.Substring(2) : parameter;
    }

    string Iz.F0(string parameter)
    {
        return parameter.Length > 0 ? '-' + parameter.Substring(1) : parameter;
    }

    string Iz.F1(string parameter)
    {
        return parameter.Length > 0 ? '-' + parameter.Substring(1) : parameter;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestClass test = new TestClass("Example");

        Ix ix = test;
        Console.WriteLine(ix.IxF0("HelloWorld"));
        Console.WriteLine(ix.IxF1("HelloWorld"));

        Iy iy = test;
        Console.WriteLine(iy.F0("HelloWorld"));
        Console.WriteLine(iy.F1("HelloWorld"));

        Iz iz = (Iz)test;
        Console.WriteLine(iz.F0("HelloWorld"));
        Console.WriteLine(iz.F1("HelloWorld"));
    }
}
