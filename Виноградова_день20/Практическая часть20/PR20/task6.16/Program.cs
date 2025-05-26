using System;
using System.IO;
using System.Linq;

/// <summary>
/// Класс Program выполняет обработку квадратной матрицы из файла, проверяет ее свойства и анализирует содержимое.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Загружает матрицу из файла, выполняет ее валидацию и анализирует свойства.
    /// </summary>
    static void Main()
    {
        const int size = 100; ///< Размер матрицы.
        string filePath = "matrix.txt"; ///< Путь к файлу с матрицей.

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Файл {filePath} не найден. Создаю пример файла...");
            GenerateExampleMatrixFile(filePath, size);
            Console.WriteLine("Файл создан. Запустите программу снова.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length != size)
            {
                Console.WriteLine($"Ошибка: требуется {size} строк, найдено {lines.Length}.");
                return;
            }

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                string[] numbers = lines[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (numbers.Length != size)
                {
                    Console.WriteLine($"Ошибка в строке {i + 1}: требуется {size} чисел, найдено {numbers.Length}.");
                    return;
                }

                for (int j = 0; j < size; j++)
                {
                    if (!int.TryParse(numbers[j], out matrix[i, j]))
                    {
                        Console.WriteLine($"Ошибка в строке {i + 1}, число {j + 1}: '{numbers[j]}' не является целым числом.");
                        return;
                    }
                }
            }

            CheckMatrix(matrix, size);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    /// <summary>
    /// Генерирует пример файла с единичной матрицей.
    /// </summary>
    /// <param name="path">Путь к файлу.</param>
    /// <param name="size">Размер матрицы.</param>
    static void GenerateExampleMatrixFile(string path, int size)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    writer.Write((i == j ? 1 : 0) + (j < size - 1 ? " " : ""));
                }
                writer.WriteLine();
            }
        }
    }

    /// <summary>
    /// Проверяет свойства матрицы: единичность, наличие нулевых строк и упорядоченность столбца.
    /// </summary>
    /// <param name="matrix">Двумерный массив, представляющий матрицу.</param>
    /// <param name="size">Размер матрицы.</param>
    static void CheckMatrix(int[,] matrix, int size)
    {
        bool isIdentity = true;

        for (int i = 0; i < size && isIdentity; i++)
        {
            for (int j = 0; j < size && isIdentity; j++)
            {
                if ((i == j && matrix[i, j] != 1) || (i != j && matrix[i, j] != 0))
                {
                    isIdentity = false;
                }
            }
        }

        Console.WriteLine($"Матрица {(isIdentity ? "является" : "не является")} единичной.");

        var zeroRows = Enumerable.Range(0, size)
            .Where(i => Enumerable.Range(0, size).All(j => matrix[i, j] == 0))
            .ToList();

        Console.WriteLine(zeroRows.Count > 0
            ? $"Нулевые строки: {string.Join(", ", zeroRows)}"
            : "Нулевых строк нет.");

        Console.Write("Введите номер столбца для проверки (0-99): ");
        if (int.TryParse(Console.ReadLine(), out int m) && m >= 0 && m < size)
        {
            bool isSorted = Enumerable.Range(1, size - 1)
                .All(i => matrix[i, m] >= matrix[i - 1, m]);

            Console.WriteLine($"Столбец {m} {(isSorted ? "упорядочен" : "не упорядочен")} по возрастанию.");
        }
        else
        {
            Console.WriteLine("Некорректный номер столбца!");
        }
    }
}
