using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double alpha = Math.PI / 6; 

        Task<double>[] tasks = new Task<double>[]
        {
            Task.Run(() => ComputeZ1(alpha)),
            Task.Run(() => ComputeZ2(alpha))
        };

        Task.WhenAll(tasks).ContinueWith(t =>
        {
            Console.WriteLine($"Все задачи выполнены:");
            Console.WriteLine($"z1 = {tasks[0].Result}");
            Console.WriteLine($"z2 = {tasks[1].Result}");
        });

        Task.WhenAny(tasks).ContinueWith(t =>
        {
            Console.WriteLine($"Хотя бы одна задача завершена.");
        });

        Task.Delay(5000).Wait();
    }

    static double ComputeZ1(double alpha)
    {
        Thread.Sleep(2000); 
        return (Math.Cos(alpha) + Math.Sin(alpha)) / (Math.Cos(alpha) - Math.Sin(alpha));
    }

    static double ComputeZ2(double alpha)
    {
        Thread.Sleep(3000); 
        return Math.Tan(2 * alpha) + (1 / Math.Cos(2 * alpha));
    }
}

