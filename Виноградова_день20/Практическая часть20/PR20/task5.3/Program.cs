using System;

/// <summary>
/// Класс RealMatrix представляет матрицу вещественных чисел с поддержкой арифметических операций.
/// </summary>
class RealMatrix
{
    private double[,] matrix;

    /// <summary>
    /// Количество строк в матрице.
    /// </summary>
    public int Rows { get; private set; }

    /// <summary>
    /// Количество столбцов в матрице.
    /// </summary>
    public int Cols { get; private set; }

    /// <summary>
    /// Создает новую матрицу заданных размеров.
    /// </summary>
    /// <param name="rows">Количество строк.</param>
    /// <param name="cols">Количество столбцов.</param>
    public RealMatrix(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        matrix = new double[rows, cols];
    }

    /// <summary>
    /// Доступ к элементам матрицы по индексам.
    /// </summary>
    /// <param name="i">Индекс строки.</param>
    /// <param name="j">Индекс столбца.</param>
    /// <returns>Число, хранящееся в ячейке матрицы.</returns>
    public double this[int i, int j]
    {
        get => matrix[i, j];
        set => matrix[i, j] = value;
    }

    /// <summary>
    /// Проверяет совместимость размеров двух матриц.
    /// </summary>
    /// <param name="a">Первая матрица.</param>
    /// <param name="b">Вторая матрица.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если размеры не совпадают.</exception>
    private static void CheckSize(RealMatrix a, RealMatrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new ArgumentException("Размеры матриц должны совпадать!");
    }

    /// <summary>
    /// Выводит содержимое матрицы в консоль.
    /// </summary>
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

/// <summary>
/// Класс Program содержит точку входа в приложение.
/// </summary>
class Program
{
    /// <summary>
    /// Демонстрирует операции над матрицами.
    /// </summary>
    static void Main()
    {
        RealMatrix matrix1 = new RealMatrix(2, 2);
        RealMatrix matrix2 = new RealMatrix(2, 2);

        Console.WriteLine("Матрица 1:");
        matrix1.Print();
        Console.WriteLine("Матрица 2:");
        matrix2.Print();
    }
}
