using System;
using System.IO;
using System.Linq;

class Program
{
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

        string newDirectory = @"D:\Exmple_38tp";
        Directory.CreateDirectory(newDirectory);
        Console.WriteLine($"\nКаталог '{newDirectory}' создан.");

        string sourceDirectory = @"D:\!!!!!!!ПРАКТИКА"; 
        string[] filesToCopy = Directory.GetFiles(sourceDirectory).Take(3).ToArray();

        foreach (var file in filesToCopy)
        {
            string destFile = Path.Combine(newDirectory, Path.GetFileName(file));
            File.Copy(file, destFile, true);
            Console.WriteLine($"Файл '{file}' скопирован в '{destFile}'.");
        }

        foreach (var file in filesToCopy)
        {
            string destFile = Path.Combine(newDirectory, Path.GetFileName(file));
            File.SetAttributes(destFile, FileAttributes.Hidden);
            Console.WriteLine($"Атрибуты файла '{destFile}' изменены на Скрытый.");
        }

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