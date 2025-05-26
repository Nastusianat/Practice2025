using System;

public class Program
{
    public delegate int RandomValueDelegate();

    public static void Main()
    {
        RandomValueDelegate[] delegates = new RandomValueDelegate[5];

        Random random = new Random();
        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = delegate
            {
                return random.Next(1, 101);
            };
        }

        Func<RandomValueDelegate[], double> calculateAverage = delegate (RandomValueDelegate[] delArray)
        {
            double sum = 0;
            foreach (var del in delArray)
            {
                sum += del();
            }
            return sum / delArray.Length;
        };

        double average = calculateAverage(delegates);
        Console.WriteLine($"Среднее арифметическое: {average:F2}");
    }
}
