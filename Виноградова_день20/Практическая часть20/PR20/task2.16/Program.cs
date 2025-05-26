using System;
using System.IO;

/// <summary>
/// Класс Program демонстрирует создание новой папки с помощью класса Directory.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в приложение. Создает папку по указанному пути и выводит сообщение о результате.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к создаваемой папке.
        /// </summary>
        string path = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\New_folder";

        /// <summary>
        /// Создание папки по указанному пути.
        /// </summary>
        Directory.CreateDirectory(path);

        Console.WriteLine("Папка 'New_folder' успешно создана.");
    }
}
