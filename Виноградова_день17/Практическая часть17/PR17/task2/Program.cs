using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"D:\!!!!!!!ПРАКТИКА\Виноградова_день17\New_folder";

        // Создание директории
        Directory.CreateDirectory(path);

        Console.WriteLine("Папка 'New_folder' успешно создана.");
    }
}

