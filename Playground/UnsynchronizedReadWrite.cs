using SynchronizationPlayground.Tools;

namespace SynchronizationPlayground.Playground;

internal class UnsynchronizedReadWrite
{
    private const int NumReaders = 3;

    private static Thread? _writer;
    private static Thread[]? _readers;

    private static volatile bool _running;

    public static async Task Run()
    {
        Console.WriteLine("Initializing unsynchronized read-write example.");

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

        await Task.WhenAll([Task.Run(_writer.Join), .. _readers.Select(r => Task.Run(r.Join))]);

        Console.WriteLine();
        Console.WriteLine("Unsynchronized read-write example completed.");
    }

    private static void WriterThreadRun()
    {
        while (_running)
        {
            Thread.Sleep(Random.Shared.Next(750));
            ReadWriteBlock.Write();
        }
    }

    private static void ReaderThreadRun()
    {
        while (_running)
        {
            Thread.Sleep(Random.Shared.Next(100));
            ReadWriteBlock.Read();
        }
    }
}
