namespace SynchronizationPlayground.Tools;

internal static class WorkBlock
{
    public static void DoWork(int iterations)
    {
        Console.WriteLine($"A thread {Thread.CurrentThread.ManagedThreadId} has entered the block!");

        for (int i = 0; i < iterations; i++)
        {
            Thread.Sleep(100);
        }

        Console.WriteLine($"A thread {Thread.CurrentThread.ManagedThreadId} has exited the block!");
    }
}