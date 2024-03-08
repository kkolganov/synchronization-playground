using SynchronizationPlayground.Tools;

namespace SynchronizationPlayground.Playground;

internal class SemaphoreSynchronizedWorkBlock
{
    private const int NumberOfWorkers = 10;
    private const int NumberOfWorkersInSemaphore = 3;

    private static readonly SemaphoreSlim _semaphore = new(NumberOfWorkersInSemaphore, NumberOfWorkersInSemaphore);

    private static Thread[]? _workers;

    public static async Task Run()
    {
        Console.WriteLine("Initializing semaphored work block example.");

        _workers = new Thread[NumberOfWorkers];

        for (int i = 0; i < _workers.Length; i++)
        {
            _workers[i] = new Thread(ThreadRun);
        }

        Console.WriteLine($"Running on {NumberOfWorkers} threads.");

        foreach (var worker in _workers)
        {
            worker.Start();
        }

        await Task.WhenAll(_workers.Select(w => Task.Run(w.Join)));

        Console.WriteLine();
        Console.WriteLine("Semaphored threads work block completed.");
    }

    private static void ThreadRun()
    {
        var amountOfWork = Random.Shared.Next(10, 20);

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has started with {amountOfWork} amount of work!");

        _semaphore.Wait();
        try
        {
            WorkBlock.DoWork(amountOfWork);
        }
        finally
        {
            _semaphore.Release();
        }

        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has finished!");
    }
}