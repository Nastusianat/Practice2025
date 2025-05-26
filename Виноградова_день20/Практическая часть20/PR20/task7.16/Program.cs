using System;
using System.IO;
using System.Linq;

/// <summary>
/// Класс Program выполняет операции с файловой системой:
/// - сканирование всех файлов на доступных дисках,
/// - создание нового каталога,
/// - копирование файлов,
/// - изменение атрибутов файлов,
/// - создание ссылок на файлы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Выполняет операции с файлами и каталогами.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Список всех файлов на локальных дисках:");
        foreach (var drive in DriveInfo.GetDrives().Where(d => d.IsReady))
        {
            try
            {
                var files = Directory.GetFiles(drive.RootDirectory.FullName, "*.*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при доступе к диску {drive.Name}: {ex.Message}");
            }
        }

        /// <summary>
        /// Создает новый каталог.
        /// </summary>
        string newDirectory = @"D:\Exmple_38tp";
        Directory.CreateDirectory(newDirectory);
        Console.WriteLine($"\nКаталог '{newDirectory}' создан.");

        /// <summary>
        /// Исходный каталог, содержащий файлы для копирования.
        /// </summary>
        string sourceDirectory = @"D:\!!!!!!!ПРАКТИКА";
        string[] filesToCopy = Directory.GetFiles(sourceDirectory).Take(3).ToArray();

        /// <summary>
        /// Копирование первых трех файлов из исходного каталога в новый каталог.
        /// </summary>
        foreach (var file in filesToCopy)
        {
            string destFile = Path.Combine(newDirectory, Path.GetFileName(file));
            File.Copy(file, destFile, true);
            Console.WriteLine($"Файл '{file}' скопирован в '{destFile}'.");
        }

        /// <summary>
        /// Установка атрибута "Скрытый" для скопированных файлов.
        /// </summary>
        foreach (var file in filesToCopy)
        {
            string destFile = Path.Combine(newDirectory, Path.GetFileName(file));
            File.SetAttributes(destFile, FileAttributes.Hidden);
            Console.WriteLine($"Атрибуты файла '{destFile}' изменены на Скрытый.");
        }

        /// <summary>
        /// Создание файла ссылки на каждый скопированный файл.
        /// </summary>
        foreach (var file in filesToCopy)
        {
            string destFile = Path.Combine(newDirectory, Path.GetFileName(file));
            string linkFile = destFile + ".lnk";

            using (var writer = new StreamWriter(linkFile))
            {
                writer.WriteLine($"Ссылка на файл: {destFile}");
            }
            Console.WriteLine($"Создан файл ссылки '{linkFile}'.");
        }
    }
}
