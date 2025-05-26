using System;

class Program
{
    public delegate string StringDelegate(string input);

    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }

    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string ReplaceSpaces(string input)
    {
        return input.Replace(" ", "_");
    }

    static void Main()
    {
        StringDelegate stringDelegate;

        string inputString = "Пример строки для работы";

        stringDelegate = ToUpperCase;
        Console.WriteLine($"Результат преобразования в верхний регистр: {stringDelegate(inputString)}");

        stringDelegate = ReverseString;
        Console.WriteLine($"Результат переворота строки: {stringDelegate(inputString)}");

        stringDelegate = ReplaceSpaces;
        Console.WriteLine($"Результат замены пробелов на подчеркивания: {stringDelegate(inputString)}");
    }
}
