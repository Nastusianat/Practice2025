using System;

class Program
{
    static void Main()
    {
        int n = 7;
        int[,] matrix = new int[n, n];

        int num = 1, left = 0, right = n - 1, top = 0, bottom = n - 1;

        while (num <= n * n)
        {
            for (int i = left; i <= right; i++) matrix[top, i] = num++;
            top++;
            for (int i = top; i <= bottom; i++) matrix[i, right] = num++;
            right--;
            for (int i = right; i >= left; i--) matrix[bottom, i] = num++;
            bottom--;
            for (int i = bottom; i >= top; i--) matrix[i, left] = num++;
            left++;
        }

        PrintMatrix(matrix, n);
    }

    static void PrintMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
