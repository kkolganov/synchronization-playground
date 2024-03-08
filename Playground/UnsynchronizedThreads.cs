namespace SynchronizationPlayground.Playground;

internal class UnsynchronizedThreads
{
    private static Thread? _worker1;
    private static Thread? _worker2;

    public static async Task Run()
    {
        Console.WriteLine("Initializing unsynchronized threads example.");

        _worker1 = new Thread(ThreadRun);
        _worker2 = new Thread(ThreadRun);
        _counter = 0;
        _totalCounts = 0;

        Console.WriteLine("Running on two threads.");

        _worker1.Start();
        _worker2.Start();

        await Task.WhenAll([Task.Run(_worker1.Join), Task.Run(_worker2.Join)]);

        Console.WriteLine();
        Console.WriteLine("Unsynchronized threads example completed.");
        Console.WriteLine($"Total number of operations: {_totalCounts}");
    }

    private static int _totalCounts;
    private static int _counter;
    private const int CountTo = 500;

    private static void ThreadRun()
    {
        var threadId = Thread.CurrentThread.ManagedThreadId;
        while (_counter < CountTo)
        {
            var localCounter = _counter;
            Console.WriteLine($"[{threadId}]: {localCounter}");
            _counter = localCounter + 1;

            // this is just for counting operations
            Interlocked.Increment(ref _totalCounts);
        }
    }
}
