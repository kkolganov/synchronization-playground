using SynchronizationPlayground.Tools;

namespace SynchronizationPlayground.Playground
{
    internal class ManualResetEventWorkerBlock
    {
        private static Thread? _worker1;
        private static Thread? _worker2;
        private static Thread? _worker3;

        private static readonly ManualResetEventSlim _waiter = new();

        public static async Task Run()
        {
            Console.WriteLine("Initializing manual reset event work block example.");

            _worker1 = new Thread(ThreadRun);
            _worker2 = new Thread(ThreadRun);
            _worker3 = new Thread(ThreadRun);

            Console.WriteLine("Running on three threads.");

            _worker1.Start();
            _worker2.Start();
            _worker3.Start();

            // setup release timers
            _ = Task.Delay(1000).ContinueWith(_ => _waiter.Set()).ConfigureAwait(false);

            await Task.WhenAll([Task.Run(_worker1.Join), Task.Run(_worker2.Join), Task.Run(_worker3.Join)]);

            Console.WriteLine();
            Console.WriteLine("Manual reset event work block completed.");
        }

        private static void ThreadRun()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has started!");

            _waiter.Wait();

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has awakened!");

            WorkBlock.DoWork(15);

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has finished!");
        }
    }
}
