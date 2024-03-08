namespace SynchronizationPlayground.Synchronization;

internal class SpinWaiter
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
        var spinner = new SpinWait();

        while (_isBusy)
        {
            // "are we there yet?!"
            spinner.SpinOnce();
        }
    }
}