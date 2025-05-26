using System;

/// <summary>
/// Класс Program демонстрирует использование делегатов для преобразования строк.
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для выполнения операций над строками.
    /// </summary>
    /// <param name="input">Входная строка.</param>
    /// <returns>Преобразованная строка.</returns>
    public delegate string StringDelegate(string input);

    /// <summary>
    /// Преобразует строку в верхний регистр.
    /// </summary>
    /// <param name="input">Исходная строка.</param>
    /// <returns>Строка в верхнем регистре.</returns>
    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }

    /// <summary>
    /// Переворачивает строку (реверсирует порядок символов).
    /// </summary>
    /// <param name="input">Исходная строка.</param>
    /// <returns>Перевернутая строка.</returns>
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    /// <summary>
    /// Заменяет пробелы в строке символами подчеркивания.
    /// </summary>
    /// <param name="input">Исходная строка.</param>
    /// <returns>Строка с замененными пробелами.</returns>
    public static string ReplaceSpaces(string input)
    {
        return input.Replace(" ", "_");
    }

    /// <summary>
    /// Точка входа в приложение. Демонстрирует работу с делегатом StringDelegate.
    /// </summary>
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
