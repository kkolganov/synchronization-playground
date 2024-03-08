using SynchronizationPlayground.Tools;

namespace SynchronizationPlayground.Playground;

internal class BarrierWorkBlock
{
    private static Thread? _worker1;
    private static Thread? _worker2;
    private static Thread? _worker3;

    private static readonly Barrier _barrier = new(participantCount: 3);

    public static async Task Run()
    {
        Console.WriteLine("Initializing Barrier synchronization work block example.");

        _worker1 = new Thread(ThreadRun);
        _worker2 = new Thread(ThreadRun);
        _worker3 = new Thread(ThreadRun);

        Console.WriteLine("Running on three threads.");

        _worker1.Start();
        _worker2.Start();
        _worker3.Start();

        await Task.WhenAll([Task.Run(_worker1.Join), Task.Run(_worker2.Join), Task.Run(_worker3.Join)]);

        Console.WriteLine();
        Console.WriteLine("Barrier synchronization work block completed.");
    }

    private const int WorkCycles = 3;

    private static void ThreadRun()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has started!");

        for (int i = 0; i < WorkCycles; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is snoozing until everyone is ready.");

            _barrier.SignalAndWait();

            var amountOfWork = Random.Shared.Next(2, 15);

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has awakened with {amountOfWork} amount of work!");

            WorkBlock.DoWork(amountOfWork);
        }

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has finished!");
    }
}