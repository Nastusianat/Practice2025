using System;

class RealMatrix
{
    private double[,] matrix;
    public int Rows { get; private set; }
    public int Cols { get; private set; }

    public RealMatrix(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        matrix = new double[rows, cols];
    }

    public double this[int i, int j]
    {
        get => matrix[i, j];
        set => matrix[i, j] = value;
    }

    public static RealMatrix operator +(RealMatrix a, RealMatrix b) // Операция сложения матриц
    {
        CheckSize(a, b);
        RealMatrix result = new RealMatrix(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < a.Cols; j++)
                result[i, j] = a[i, j] + b[i, j];
        return result;
    }

    public static RealMatrix operator -(RealMatrix a, RealMatrix b) // Операция вычитания матриц
    {
        CheckSize(a, b);
        RealMatrix result = new RealMatrix(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < a.Cols; j++)
                result[i, j] = a[i, j] - b[i, j];
        return result;
    }

    // Операции с числом
    public static RealMatrix operator +(RealMatrix a, double value) => ApplyScalarOperation(a, value, true);
    public static RealMatrix operator -(RealMatrix a, double value) => ApplyScalarOperation(a, value, false);

    public void AddMatrix(RealMatrix other)// Операторы комбинированного присваивания
    {
        CheckSize(this, other);
        for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Cols; j++)
                matrix[i, j] += other[i, j];
    }

    public void SubtractMatrix(RealMatrix other)
    {
        CheckSize(this, other);
        for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Cols; j++)
                matrix[i, j] -= other[i, j];
    }

    public static bool operator ==(RealMatrix a, RealMatrix b) // Операторы сравнения
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols) return false;
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < a.Cols; j++)
                if (a[i, j] != b[i, j]) return false;
        return true;
    }

    public static bool operator !=(RealMatrix a, RealMatrix b) => !(a == b);

    private static void CheckSize(RealMatrix a, RealMatrix b)// Проверка размеров матриц
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new ArgumentException("Размеры матриц должны совпадать!");
    }

    private static RealMatrix ApplyScalarOperation(RealMatrix a, double value, bool addition)// Метод для применения операции с числом
    {
        RealMatrix result = new RealMatrix(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < a.Cols; j++)
                result[i, j] = addition ? a[i, j] + value : a[i, j] - value;
        return result;
    }

    public void Print()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
                Console.Write($"{matrix[i, j]:F2}\t");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        RealMatrix matrix1 = new RealMatrix(2, 2)
        {
            [0, 0] = 1.5,
            [0, 1] = 2.5,
            [1, 0] = 3.5,
            [1, 1] = 4.5
        };

        RealMatrix matrix2 = new RealMatrix(2, 2)
        {
            [0, 0] = 0.5,
            [0, 1] = 1.5,
            [1, 0] = 2.5,
            [1, 1] = 3.5
        };

        Console.WriteLine("Матрица 1:");
        matrix1.Print();
        Console.WriteLine("Матрица 2:");
        matrix2.Print();

        Console.WriteLine("Сложение матриц:");
        RealMatrix sumMatrix = matrix1 + matrix2;
        sumMatrix.Print();

        Console.WriteLine("Вычитание матриц:");
        RealMatrix diffMatrix = matrix1 - matrix2;
        diffMatrix.Print();

        Console.WriteLine("Добавление числа 2 к матрице:");
        RealMatrix addedNumber = matrix1 + 2;
        addedNumber.Print();

        Console.WriteLine("Вычитание числа 1 из матрицы:");
        RealMatrix subtractedNumber = matrix1 - 1;
        subtractedNumber.Print();

        Console.WriteLine("Проверяем операцию +=");
        matrix1.AddMatrix(matrix2);
        matrix1.Print();

        Console.WriteLine("Проверяем операцию -=");
        matrix1.SubtractMatrix(matrix2);
        matrix1.Print();

        Console.WriteLine($"Матрицы равны? {matrix1 == matrix2}");
        Console.WriteLine($"Матрицы не равны? {matrix1 != matrix2}");
    }
}
