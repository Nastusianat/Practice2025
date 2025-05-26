using System;
using System.Collections.Generic;

public class DiaryEntry : ICloneable
{
    public DateTime Date { get; set; }
    public string Content { get; set; }
    public int? MoodRating { get; set; } // Используем обнуляемый тип

    public DiaryEntry(DateTime date, string content, int? moodRating = null)
    {
        Date = date;
        Content = content;
        MoodRating = moodRating;
    }

    public object Clone()
    {
        return new DiaryEntry(Date, Content, MoodRating);
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Content} (Настроение: {MoodRating?.ToString() ?? "не указано"})";
    }
}

public class Diary<T> where T : ICloneable
{
    private List<T> entries = new List<T>();
    private Dictionary<DateTime, T> entryDictionary = new Dictionary<DateTime, T>();

    public void AddEntry(DateTime date, T entry)
    {
        entries.Add(entry);
        entryDictionary[date] = entry;
    }

    public void RemoveEntry(DateTime date)
    {
        if (entryDictionary.ContainsKey(date))
        {
            T entry = entryDictionary[date];
            entries.Remove(entry);
            entryDictionary.Remove(date);
        }
    }

    public T CloneEntry(DateTime date)
    {
        return entryDictionary.ContainsKey(date) ? (T)entryDictionary[date].Clone() : default;
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Записи в дневнике:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
}

class Program
{
    static void Main()
    {
        Diary<DiaryEntry> myDiary = new Diary<DiaryEntry>();

        var entry1 = new DiaryEntry(DateTime.Now, "Сегодня был хороший день", 8);
        var entry2 = new DiaryEntry(DateTime.Now.AddDays(-1), "Работы много, но справился!", 6);

        myDiary.AddEntry(entry1.Date, entry1);
        myDiary.AddEntry(entry2.Date, entry2);

        myDiary.DisplayEntries();

        Console.WriteLine("\nКлонирование записи:");
        var clonedEntry = myDiary.CloneEntry(entry1.Date);
        Console.WriteLine(clonedEntry);

        Console.WriteLine("\nУдаление второй записи..");
        myDiary.RemoveEntry(entry2.Date);
        myDiary.DisplayEntries();
    }
}
