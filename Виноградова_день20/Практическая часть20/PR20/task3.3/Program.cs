using System;

/// <summary>
/// Класс StringMatrix представляет матрицу строк с поддержкой операций и индексации.
/// </summary>
class StringMatrix
{
    private string[,] matrix;
    private int rows;
    private int cols;

    /// <summary>
    /// Создает новую строковую матрицу заданного размера.
    /// </summary>
    /// <param name="rows">Количество строк.</param>
    /// <param name="cols">Количество столбцов.</param>
    public StringMatrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        matrix = new string[rows, cols];
    }

    /// <summary>
    /// Доступ к элементам матрицы по индексам.
    /// </summary>
    /// <param name="i">Индекс строки.</param>
    /// <param name="j">Индекс столбца.</param>
    /// <returns>Строка, хранящаяся в данной ячейке матрицы.</returns>
    public string this[int i, int j]
    {
        get => matrix[i, j];
        set => matrix[i, j] = value;
    }

    /// <summary>
    /// Оператор сложения двух матриц строк. Объединяет соответствующие элементы через пробел.
    /// </summary>
    /// <param name="a">Первая матрица.</param>
    /// <param name="b">Вторая матрица.</param>
    /// <returns>Результирующая матрица, содержащая объединенные строки.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если размеры матриц не совпадают.</exception>
    public static StringMatrix operator +(StringMatrix a, StringMatrix b)
    {
        if (a.rows != b.rows || a.cols != b.cols)
            throw new ArgumentException("Размеры матриц должны совпадать!");

        StringMatrix result = new StringMatrix(a.rows, a.cols);
        for (int i = 0; i < a.rows; i++)
        {
            for (int j = 0; j < a.cols; j++)
            {
                result[i, j] = $"{a[i, j]} {b[i, j]}";
            }
        }

        return result;
    }

    /// <summary>
    /// Выводит содержимое матрицы в консоль.
    /// </summary>
    public void Print()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j].PadRight(15));
            }
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
    /// Создает две матрицы строк, объединяет их и выводит результат.
    /// </summary>
    static void Main()
    {
        StringMatrix matrix1 = new StringMatrix(2, 2)
        {
            [0, 0] = "Привет",
            [0, 1] = "Мир",
            [1, 0] = "Как",
            [1, 1] = "дела?"
        };

        StringMatrix matrix2 = new StringMatrix(2, 2)
        {
            [0, 0] = "!",
            [0, 1] = "?",
            [1, 0] = "у",
            [1, 1] = "тебя."
        };

        StringMatrix result = matrix1 + matrix2;

        Console.WriteLine("Результирующая матрица:");
        result.Print();
    }
}
