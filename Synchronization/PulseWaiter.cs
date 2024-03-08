namespace SynchronizationPlayground.Synchronization;

internal class PulseWaiter
{
    private readonly object _locker = new();
    private bool _isBusy = false;

    public void Wait()
    {
        _isBusy = true;

        lock (_locker)
        {
            while (_isBusy)
            {
                Monitor.Wait(_locker);
            }
        }
    }

    public void Pulse()
    {
        lock (_locker)
        {
            _isBusy = false;
            Monitor.Pulse(_locker);
        }
    }

    public void PulseAll()
    {
        lock (_locker)
        {
            _isBusy = false;
            Monitor.PulseAll(_locker);
        }
    }
}