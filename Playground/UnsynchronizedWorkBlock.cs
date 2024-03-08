using SynchronizationPlayground.Tools;
using System.Diagnostics.Metrics;

namespace SynchronizationPlayground.Playground;

internal class UnsynchronizedWorkBlock
{
    private static Thread? _worker1;
    private static Thread? _worker2;
    private static readonly object _locker = new object();

    public static async Task Run()
    {
        Console.WriteLine("Initializing unsynchronized work block example.");

        _worker1 = new Thread(ThreadOneRun);
        _worker2 = new Thread(ThreadTwoRun);

        Console.WriteLine("Running on two threads.");

        _worker1.Start();
        _worker2.Start();

        await Task.WhenAll([Task.Run(_worker1.Join), Task.Run(_worker2.Join)]);

        Console.WriteLine();
        Console.WriteLine("Unsynchronized threads work block completed.");
    }

    private static void ThreadOneRun()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has started!");

        WorkBlock.DoWork(10);

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has finished!");
    }

    private static void ThreadTwoRun()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has started!");

        WorkBlock.DoWork(20);

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has finished!");
    }
}
