using System;

class Program
{
    static void DigitCountSum(int K, out int C, out int S)
    {
        C = 0;
        S = 0;
        while (K > 0)
        {
            S += K % 10; // Добавляем последнюю цифру к сумме
            C++;         // Увеличиваем счетчик цифр
            K /= 10;     // Убираем последнюю цифру
        }
    }

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
