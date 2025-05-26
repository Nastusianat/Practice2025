using System;
using System.Collections;
using System.Collections.Generic;

class MusicCatalog
{
    private Hashtable catalog = new Hashtable();

    public void AddDisk(string diskName)
    {
        if (!catalog.ContainsKey(diskName))
        {
            catalog[diskName] = new List<string>();
            Console.WriteLine($"Диск '{diskName}' добавлен в каталог.");
        }
        else
        {
            Console.WriteLine($"Диск '{diskName}' уже существует.");
        }
    }

    public void RemoveDisk(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            catalog.Remove(diskName);
            Console.WriteLine($"Диск '{diskName}' удален.");
        }
        else
        {
            Console.WriteLine($"Диск '{diskName}' не найден.");
        }
    }

    public void AddSong(string diskName, string song)
    {
        if (catalog.ContainsKey(diskName))
        {
            ((List<string>)catalog[diskName]).Add(song);
            Console.WriteLine($"Песня '{song}' добавлена на диск '{diskName}'.");
        }
        else
        {
            Console.WriteLine($"Диск '{diskName}' не найден.");
        }
    }

    public void RemoveSong(string diskName, string song)
    {
        if (catalog.ContainsKey(diskName))
        {
            List<string> songs = (List<string>)catalog[diskName];
            if (songs.Remove(song))
            {
                Console.WriteLine($"Песня '{song}' удалена с диска '{diskName}'.");
            }
            else
            {
                Console.WriteLine($"Песня '{song}' не найдена на диске '{diskName}'.");
            }
        }
        else
        {
            Console.WriteLine($"Диск '{diskName}' не найден.");
        }
    }

    public void ShowCatalog()
    {
        Console.WriteLine("\nКаталог компакт-дисков:");
        foreach (DictionaryEntry entry in catalog)
        {
            Console.WriteLine($"Диск: {entry.Key}");
            foreach (string song in (List<string>)entry.Value)
            {
                Console.WriteLine($"  - {song}");
            }
        }
    }

    public void ShowDiskContents(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            Console.WriteLine($"Содержимое диска '{diskName}':");
            foreach (string song in (List<string>)catalog[diskName])
            {
                Console.WriteLine($"  - {song}");
            }
        }
        else
        {
            Console.WriteLine($"Диск '{diskName}' не найден.");
        }
    }
}

class Program
{
    static void Main()
    {
        MusicCatalog catalog = new MusicCatalog();

        catalog.AddDisk("Rock Classics");
        catalog.AddSong("Rock Classics", "Bohemian Rhapsody");
        catalog.AddSong("Rock Classics", "Stairway to Heaven");

        catalog.AddDisk("Pop Hits");
        catalog.AddSong("Pop Hits", "Thriller");
        catalog.AddSong("Pop Hits", "Like a Prayer");

        catalog.ShowCatalog();

        Console.WriteLine("\nУдаляем песню:");
        catalog.RemoveSong("Rock Classics", "Stairway to Heaven");

        Console.WriteLine("\nСодержимое диска:");
        catalog.ShowDiskContents("Rock Classics");
    }
}
