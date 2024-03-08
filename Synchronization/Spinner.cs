namespace SynchronizationPlayground.Synchronization;

internal class Spinner
{
    private volatile bool _isBusy = false;

    public void Acquire()
    {
        Spin();

        _isBusy = true;
    }

    public void Release()
    {
        _isBusy = false;
    }

    private void Spin()
    {
        while (_isBusy)
        {
            // "are we there yet?!"
            Thread.MemoryBarrier();
        }
    }
}