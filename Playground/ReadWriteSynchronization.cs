using SynchronizationPlayground.Tools;

namespace SynchronizationPlayground.Playground;

internal class ReadWriteSynchronization
{
    private const int NumReaders = 3;

    private static Thread? _writer;
    private static Thread[]? _readers;

    private static volatile bool _running;

    private static readonly ReaderWriterLockSlim _rwLock = new();

    public static async Task Run()
    {
        Console.WriteLine("Initializing read-write synchronization example.");

        _writer = new Thread(WriterThreadRun);

        _readers = new Thread[NumReaders];
        for (int i = 0; i < NumReaders; i++)
        {
            _readers[i] = new Thread(ReaderThreadRun);
        }

        Console.WriteLine($"Running on {NumReaders + 1} threads.");

        _running = true;
        _writer.Start();

        foreach (var reader in _readers)
        {
            reader.Start();
        }

        _ = Task.Delay(7000).ContinueWith(_ => _running = false).ConfigureAwait(false);

        await Task.WhenAll([Task.Run(_writer.Join), .._readers.Select(r => Task.Run(r.Join))]);

        Console.WriteLine();
        Console.WriteLine("Read-write synchronization example completed.");
    }

    private static void WriterThreadRun()
    {
        while (_running)
        {
            Thread.Sleep(Random.Shared.Next(750));

            _rwLock.EnterWriteLock();

            try
            {
                ReadWriteBlock.Write();
            }
            finally
            {
                _rwLock.ExitWriteLock();
            }
        }
    }

    private static void ReaderThreadRun()
    {
        while (_running)
        {
            Thread.Sleep(Random.Shared.Next(100));

            _rwLock.EnterReadLock();

            try
            {
                ReadWriteBlock.Read();
            }
            finally
            {
                _rwLock.ExitReadLock();
            }
        }
    }
}