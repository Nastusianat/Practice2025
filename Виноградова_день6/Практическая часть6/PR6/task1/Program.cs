using System;

class Program
{
    static void Main()
    {
        int[] array = { 12, 3, 45, 1, 23, 56, 1, 7 };

        int minValue = array[0];
        int minIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }
        }

        Console.WriteLine($"Минимальный элемент: {minValue}, его индекс: {minIndex}");
    }
}

