using System.Diagnostics.Metrics;

namespace SynchronizationPlayground.Playground;

internal class InterlockedCounter
{
    private static Thread? _worker1;
    private static Thread? _worker2;
    private static Thread? _worker3;

    public static async Task Run()
    {
        Console.WriteLine("Initializing interlocked counter example.");

        _worker1 = new Thread(ThreadRun);
        _worker2 = new Thread(ThreadRun);
        _worker3 = new Thread(ThreadRun);
        _counter = 0;

        Console.WriteLine("Running on two threads.");

        _worker1.Start();
        _worker2.Start();
        _worker3.Start();

        await Task.WhenAll([Task.Run(_worker1.Join), Task.Run(_worker2.Join), Task.Run(_worker3.Join)]);

        Console.WriteLine();
        Console.WriteLine("Interlocked counter example completed.");
        Console.WriteLine($"Total number of operations: {_totalCounts}");
    }

    private static int _totalCounts;
    private static int _counter;
    private const int CountTo = 500;

    private static void ThreadRun()
    {
        var threadId = Thread.CurrentThread.ManagedThreadId;

        while (true)
        {
            var localCounter = Thread.VolatileRead(ref _counter);
            if (localCounter >= CountTo)
            {
                break;
            }

            Console.WriteLine($"[{threadId}]: {localCounter}");

            Interlocked.CompareExchange(ref _counter, localCounter + 1, localCounter);
            Interlocked.Increment(ref _totalCounts);
        }
    }
}