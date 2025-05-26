using System;

/// <summary>
/// Основной класс программы, демонстрирующий работу с делегатами и анонимными методами.
/// </summary>
public class Program
{
    /// <summary>
    /// Делегат, представляющий метод генерации случайного целого числа.
    /// </summary>
    /// <returns>Случайное целое число.</returns>
    public delegate int RandomValueDelegate();

    /// <summary>
    /// Точка входа в приложение. Создает массив делегатов, вычисляет среднее значение случайных чисел и выводит его.
    /// </summary>
    public static void Main()
    {
        // Создание массива делегатов для генерации случайных чисел
        RandomValueDelegate[] delegates = new RandomValueDelegate[5];

        Random random = new Random();
        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = delegate
            {
                return random.Next(1, 101);
            };
        }

        /// <summary>
        /// Анонимный метод, вычисляющий среднее арифметическое значений, возвращаемых массивом делегатов.
        /// </summary>
        /// <param name="delArray">Массив делегатов.</param>
        /// <returns>Среднее арифметическое значение.</returns>
        Func<RandomValueDelegate[], double> calculateAverage = delegate (RandomValueDelegate[] delArray)
        {
            double sum = 0;
            foreach (var del in delArray)
            {
                sum += del();
            }
            return sum / delArray.Length;
        };

        // Вычисление среднего арифметического и вывод результата
        double average = calculateAverage(delegates);
        Console.WriteLine($"Среднее арифметическое: {average:F2}");
    }
}
