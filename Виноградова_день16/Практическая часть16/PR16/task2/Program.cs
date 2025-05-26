using System;

public class MyDictionary<TKey, TValue>
{
    private TKey[] keys;
    private TValue[] values;
    private int count;

    public MyDictionary()
    {
        keys = new TKey[4];
        values = new TValue[4];
        count = 0;
    }

    public void Add(TKey key, TValue value)
    {
        if (count == keys.Length)
        {
            Array.Resize(ref keys, keys.Length * 2);
            Array.Resize(ref values, values.Length * 2);
        }
        keys[count] = key;
        values[count] = value;
        count++;
    }

    public TValue this[TKey key]
    {
        get
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i].Equals(key))
                    return values[i];
            }
            throw new KeyNotFoundException("Ключ не найден.");
        }
    }

    public int Count => count;
}

class Program
{
    static void Main()
    {
        MyDictionary<int, string> myDict = new MyDictionary<int, string>();
        myDict.Add(1, "Один");
        myDict.Add(2, "Два");
        myDict.Add(3, "Три");

        Console.WriteLine($"Количество пар: {myDict.Count}");
        Console.WriteLine($"Значение по ключу 2: {myDict[2]}");
    }
}
