using SynchronizationPlayground.Synchronization;
using SynchronizationPlayground.Tools;

namespace SynchronizationPlayground.Playground;

internal class PulseWaitWorkBlock
{
    private static Thread? _worker1;
    private static Thread? _worker2;
    private static Thread? _worker3;

    private static readonly PulseWaiter _pulseWaiter = new();

    public static async Task Run()
    {
        Console.WriteLine("Initializing Pulse/Wait work block example.");

        _worker1 = new Thread(ThreadRun);
        _worker2 = new Thread(ThreadRun);
        _worker3 = new Thread(ThreadRun);

        Console.WriteLine("Running on two threads.");

        _worker1.Start();
        _worker2.Start();
        _worker3.Start();

        // setup release timers
        _ = Task.Delay(1000).ContinueWith(_ => Pulse()).ConfigureAwait(false);
        _ = Task.Delay(3000).ContinueWith(_ => PulseAll()).ConfigureAwait(false);

        await Task.WhenAll([Task.Run(_worker1.Join), Task.Run(_worker2.Join), Task.Run(_worker3.Join)]);

        Console.WriteLine();
        Console.WriteLine("Pulse/Wait work block completed.");
    }

    private static void Pulse()
    {
        Console.WriteLine("Pulsing the PulseWaiter once, this should release one thread.");
        _pulseWaiter.Pulse();
    }
    private static void PulseAll()
    {
        Console.WriteLine("Pulsing the PulseWaiter with PulseAll, this should release all the remaining threads.");
        _pulseWaiter.PulseAll();
    }

    private static void ThreadRun()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has started!");

        _pulseWaiter.Wait();

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has awakened!");

        WorkBlock.DoWork(15);

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has finished!");
    }
}
