using System;
using System.Threading;

class Program
{
    static int A, N;
    static readonly object lockObj = new object();

    static void SumMethod()
    {
        int sum = A;
        for (int i = 1; i <= N; i++)
        {
            sum += A;
        }
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Сумма = {sum}");
    }

    static void ProductMethod()
    {
        lock (lockObj) 
        {
            int product = A;
            for (int i = 1; i <= N; i++)
            {
                product *= A;
                Thread.Sleep(50);
            }
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Произведение = {product}");
        }
    }

    static void Main()
    {
        Console.Write("Введите значение A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        N = int.Parse(Console.ReadLine());

        Thread thread1 = new Thread(SumMethod);
        Thread thread2 = new Thread(SumMethod);
        Thread productThread = new Thread(ProductMethod);

        thread1.Start();
        thread2.Start();
        productThread.Start();

        thread1.Join();
        thread2.Join();
        productThread.Join();

        Console.WriteLine("Все потоки завершены.");
    }
}
