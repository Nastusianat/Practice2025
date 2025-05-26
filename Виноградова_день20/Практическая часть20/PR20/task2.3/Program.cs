using System;

/// <summary>
/// Класс Program содержит методы для анализа целых чисел.
/// </summary>
class Program
{
    /// <summary>
    /// Определяет количество цифр и сумму цифр в заданном числе.
    /// </summary>
    /// <param name="K">Целое число, которое анализируется.</param>
    /// <param name="C">Выходной параметр, содержащий количество цифр в числе.</param>
    /// <param name="S">Выходной параметр, содержащий сумму цифр числа.</param>
    static void DigitCountSum(int K, out int C, out int S)
    {
        C = 0;
        S = 0;
        while (K > 0)
        {
            S += K % 10;
            C++;
            K /= 10;
        }
    }

    /// <summary>
    /// Запрашивает у пользователя пять целых положительных чисел и выводит количество и сумму их цифр.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Введите 5 целых положительных чисел:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Число {i + 1}: ");
            int K = int.Parse(Console.ReadLine());

            DigitCountSum(K, out int C, out int S);
            Console.WriteLine($"Количество цифр: {C}, Сумма цифр: {S}");
        }
    }
}
