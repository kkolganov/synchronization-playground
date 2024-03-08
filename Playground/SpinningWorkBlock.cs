using SynchronizationPlayground.Synchronization;
using SynchronizationPlayground.Tools;

namespace SynchronizationPlayground.Playground;

internal class SpinningWorkBlock
{
    private static Thread? _worker1;
    private static Thread? _worker2;

    private static readonly Spinner _spinner = new();

    public static async Task Run()
    {
        Console.WriteLine("Initializing spinner-synchronized work block example.");

        _worker1 = new Thread(ThreadRun);
        _worker2 = new Thread(ThreadRun);

        Console.WriteLine("Running on two threads.");

        _worker1.Start();
        _worker2.Start();

        await Task.WhenAll([Task.Run(_worker1.Join), Task.Run(_worker2.Join)]);

        Console.WriteLine();
        Console.WriteLine("Spinner-synchronized threads work block completed.");
    }

    private static void ThreadRun()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has started!");

        _spinner.Acquire();
        try
        {
            WorkBlock.DoWork(10);
        }
        finally
        {
            _spinner.Release();
        }

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has finished!");
    }
}
