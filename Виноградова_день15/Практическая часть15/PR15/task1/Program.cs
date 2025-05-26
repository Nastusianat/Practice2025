﻿using System;
using System.Threading;

class Program
{
    static AutoResetEvent firstEvent = new AutoResetEvent(true);
    static AutoResetEvent secondEvent = new AutoResetEvent(false);
    static AutoResetEvent thirdEvent = new AutoResetEvent(false);

    static void PrintNumbers(int start, int end, AutoResetEvent myEvent, AutoResetEvent nextEvent, ThreadPriority priority)
    {
        Thread.CurrentThread.Priority = priority;

        for (int i = start; i <= end; i++)
        {
            myEvent.WaitOne();
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: {i}");
            Thread.Sleep(100); 
            nextEvent.Set();
        }
    }

    static void Main()
    {
        Thread firstThread = new Thread(() => PrintNumbers(0, 9, firstEvent, secondEvent, ThreadPriority.Highest));
        Thread secondThread = new Thread(() => PrintNumbers(10, 19, secondEvent, thirdEvent, ThreadPriority.Normal));
        Thread thirdThread = new Thread(() => PrintNumbers(20, 29, thirdEvent, firstEvent, ThreadPriority.Lowest));

        firstThread.Start();
        secondThread.Start();
        thirdThread.Start();

        firstThread.Join();
        secondThread.Join();
        thirdThread.Join();

        Console.WriteLine("Все потоки завершены.");
    }
}

